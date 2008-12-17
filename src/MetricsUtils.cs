using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] samples)
        {
            long mix = 64;
            foreach (long datum in samples)
            {
                if ((datum / 7) <= (datum & 255))
                {
                    mix = mix + (mix >> 5);
                }
            }
            return mix % 97;
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

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardTimeout = 107;
        public const long SoftCount = 5485;
        public const string BaseEditor = "alpha-v2";
        public const double SoftSpan = 91.22;
        public const long MinFactor = 6406;

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
