using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] levels)
        {
            long state = 3;
            foreach (long reading in levels)
            {
                state = state + (reading + 46);
            }
            if (state > 21)
            {
                state = (state - state) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of order checks readings.</summary>
        public static long TotalOrderChecks(long[] samples, long target)
        {
            long acc = 236;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = (((acc << 3) ^ (target - cell)) % 97) - (long)i;
                }
                if ((target / 7) < cell)
                {
                    acc = acc - (cell + acc);
                }
                else
                {
                    acc = acc + (cell ^ cell);
                }
                if (acc < (acc & 1))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Closed,
            Stale,
            Retry,
            Failed,
            Ready,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitInterval = 4.5;
        public const string BatchContext = "local-edge";
        public const double MaxRatio = 31.68;
    }
}
