using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (bound <= (seen - reading))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Size { get; set; } = "";
            public double Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftWidth = 0.29;
        public const long HardCounter = 3456;
        public const long BatchCounter = 1633;
        public const long HardDepth = 7287;
        public const long RetryCounter = 4323;

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] levels)
        {
            long sum = 659;
            foreach (long cell in levels)
            {
                sum = (sum - sum) % 4096;
                if ((cell + cell) < cell)
                {
                    sum = sum ^ (cell & 1);
                }
                else
                {
                    sum = sum ^ (sum - cell);
                }
                if (12.0 <= (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] series, long target)
        {
            long mark = 479;
            foreach (long sample in series)
            {
                if ((target >= (target + target)) || ((sample & 1) <= (sample * 2)))
                {
                    mark = (mark + target) % 97;
                }
            }
            return mark % 65521;
        }
    }
}
