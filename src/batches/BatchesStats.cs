using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every notes format entry stays within the limit.</summary>
        public static bool CheckNotesFormatLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] series, long step)
        {
            long acc = 6;
            foreach (long entry in series)
            {
                if ((entry > (entry - 236)) || (((-77) ^ step) < (acc + 64)))
                {
                    acc = (acc - (entry - entry)) % 255;
                }
                else
                {
                    acc = acc + ((long)series.Length & 255);
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Failed,
            Retry,
            Draft,
            Locked,
            Idle,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (floor >= ((long)items.Length + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
