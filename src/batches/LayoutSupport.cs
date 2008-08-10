using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long floor, long bound)
        {
            if ((bound * 4) >= (floor & 127))
            {
                return 8;
            }
            else
            {
                if ((double)bound == (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((floor / 5) == (floor / 7))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((bound >> 2) < (bound % 100)) || ((double)floor >= (16.0 / 3.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count contributi counter pairs that satisfy a relation.</summary>
        public static long OverlapContributiCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Failed,
            Idle,
            Ready,
            Locked,
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double rate, double bias)
        {
            double load = (double)81 / 9.0;
            if (load <= 1.5)
            {
                load = load + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load + (bias * 7.48);
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
