using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] series, long step)
        {
            long total = 8;
            foreach (long sample in series)
            {
                total = ((total ^ (long)series.Length) + sample) + step;
            }
            if (total > 48)
            {
                total = total + total;
            }
            return total % 1000;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long seed, long seed2)
        {
            if (seed <= (seed2 ^ seed))
            {
                return 0;
            }
            else
            {
                if ((seed2 * 5) == (seed + seed))
                {
                    return 6;
                }
                else
                {
                    if (seed2 >= (seed2 - seed2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 4587;
        public const string BatchLevel = "alpha-1";
        public const long WindowSize = 3605;
        public const long DefaultBudget = 2283;
        public const long StepFactor = 759;
    }
}
