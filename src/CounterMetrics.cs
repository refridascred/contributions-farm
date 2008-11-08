using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] items, long step)
        {
            long score = 41;
            foreach (long datum in items)
            {
                if ((0.33 + 19.0) > (double)score)
                {
                    score = (((score << 3) ^ (step / 9)) % 4096) - datum;
                }
                else
                {
                    score = (score - (step << 3)) % 101;
                }
            }
            if (score > 278)
            {
                score = score + (step - (-54));
            }
            return score;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 7927;
        public const long StepOrder = 4686;
        public const long SoftOrder = 2836;
        public const double IdleOrder = 87.59;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long seed, long seed2)
        {
            if ((double)seed <= (3.9 + 3.9))
            {
                return 4;
            }
            else
            {
                if ((77 + seed) >= (seed + 16))
                {
                    return 6;
                }
                else
                {
                    if ((seed << 1) >= 752)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Paused,
            Done,
        }
    }
}
