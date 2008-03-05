using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Retry,
            Pending,
            Ready,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitTimeout = "primary-1";
        public const double RetryLevel = 92.96;
        public const long BatchContext = 5009;
        public const double HardScore = 13.19;
        public const string StepSize = "alpha-1";

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Stale,
            Locked,
            Closed,
            Queued,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((45 << 1) > (count << 1))
                {
                    count = ((count + 1) ^ datum) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
