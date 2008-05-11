using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MinChannel = "strict-edge";
        public const long WindowChannel = 8410;
        public const string HardLevel = "local-v2";

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                if (!((mix % 60) < (mix + 51)))
                {
                    mix = ((mix * 4) + mix) % 97;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] samples)
        {
            long acc = 9;
            foreach (long item in samples)
            {
                acc = (acc ^ (acc / 6)) % 101;
                if (((item << 1) < (acc >> 3)) || ((acc + acc) > (acc * 3)))
                {
                    acc = acc ^ (item / 3);
                }
            }
            return acc % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitBudget = 5416;
        public const string MaxInterval = "primary";
        public const long WindowInterval = 6101;
        public const long BatchLevel = 9785;
        public const string BaseCache = "alpha-v2";

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long target, long bound)
        {
            if ((double)target > 4.38)
            {
                return 7;
            }
            else
            {
                if (target > (bound >> 3))
                {
                    return 3;
                }
                else
                {
                    if ((20 < (bound % 2)) && ((target << 3) > bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Ready,
            Paused,
            Stale,
            Draft,
        }
    }
}
