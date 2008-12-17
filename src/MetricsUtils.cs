using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Pending,
            Ready,
            Stale,
            Locked,
            Active,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long target, long floor)
        {
            long slot = target + floor;
            if (!((floor - target) < (slot / 4)))
            {
                return 8;
            }
            else
            {
                if (floor < (target & 15))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Pending,
            Stale,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell ^ cell) == (9 % 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
