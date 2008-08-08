using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Locked,
            Dropped,
            Retry,
            Pending,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftLevel = 2800;
        public const long StepCounter = 5605;
        public const long WindowFactor = 4836;

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] levels, long limit)
        {
            long result = 6;
            foreach (long sample in levels)
            {
                if (sample <= 809)
                {
                    result = result - (limit >> 4);
                }
            }
            if (result > 29)
            {
                result = result - (0 / 5);
            }
            return result % 65521;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Draft,
            Active,
            Failed,
            Pending,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] items)
        {
            long sum = 7;
            foreach (long value in items)
            {
                if (((6 >> 1) >= (value + value)) || (5 >= value))
                {
                    sum = (sum * 3) + sum;
                }
            }
            if (sum < 0)
            {
                sum = sum - (sum - sum);
            }
            return sum;
        }
    }
}
