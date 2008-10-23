using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine already channel values into a single score.</summary>
        public static long FoldAlreadyChannel(long[] samples)
        {
            long result = 9;
            foreach (long cell in samples)
            {
                if (0 < cell)
                {
                    result = (result ^ result) % 4096;
                }
                if ((result >> 4) > (15 + cell))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 251;
        public const string LimitFarm = "staging-1";
        public const long CacheFactor = 7927;
        public const string IdleRatio = "legacy-edge";
        public const double HardInterval = 31.86;

        /// <summary>Count farm report pairs that satisfy a relation.</summary>
        public static long CompareFarmReportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
