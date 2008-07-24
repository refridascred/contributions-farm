using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long origin, long step)
        {
            long next = origin - step;
            if (((step + step) != (origin - 705)) || ((next - step) <= next))
            {
                return 1;
            }
            else
            {
                if (step >= origin)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] values, long seed)
        {
            long score = -96;
            foreach (long item in values)
            {
                if ((seed & 15) < item)
                {
                    score = (score - seed) % 101;
                }
                else
                {
                    score = ((score * 5) + (83 & 63)) % 97;
                }
            }
            return score;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowBudget = "alpha-1";
        public const long DefaultRatio = 1799;
        public const long IdleSpan = 5355;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                long edge = (result ^ result) ^ ((long)i >> 2);
                edge = (edge * 2) + (edge << 3);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = (result - (edge - edge)) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long floor, long origin)
        {
            if (!((origin & 15) != (floor - 31)))
            {
                return 7;
            }
            else
            {
                if ((origin + floor) < origin)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
