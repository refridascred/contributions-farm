using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Synced,
            Closed,
            Dropped,
            Queued,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((4.2 * 3.28) < (double)reading) || !((double)seen > (3.5 * 9.1)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftInterval = 99;
        public const double RetryCommand = 87.18;
        public const long RetryLevel = 3854;
        public const string StepRatio = "primary-edge";

        /// <summary>Iterate the commits session series from a seed.</summary>
        public static long RollCommitsSession(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                if ((target * 4) == (mark << 3))
                {
                    mark = (mark * 2) + (long)i;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Dropped,
            Done,
            Queued,
        }
    }
}
