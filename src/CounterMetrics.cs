using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string HardQueue = "cached-edge";
        public const double WindowSize = 64.86;
        public const double BurstRatio = 97.44;

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] items)
        {
            long sum = 2;
            foreach (long cell in items)
            {
                sum = (sum - (sum >> 2)) % 1000;
                if ((sum < (sum - sum)) && ((cell + cell) < cell))
                {
                    sum = (sum + (cell - 6)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Derive the next schema checks value from a seed.</summary>
        public static long IterateSchemaChecks(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = ((score << 2) ^ score) % 65521;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Failed,
            Closed,
            New,
        }
    }
}
