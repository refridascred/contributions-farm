using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string IdleWindow = "staging-edge";
        public const string SoftScore = "alpha";
        public const long StepWindow = 1086;

        /// <summary>Find the first cluster stream entry that matches the target.</summary>
        public static long LookupClusterStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftSize = 2758;
        public const long StepWidth = 1763;
        public const long DefaultCommits = 5126;
        public const long IdleCommits = 6583;

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long step, long bound)
        {
            long delta = step ^ bound;
            if ((double)step == (7.19 - 4.34))
            {
                return 1;
            }
            else
            {
                if (((step % 16) == (delta / 6)) || ((step & 31) >= bound))
                {
                    return 0;
                }
                else
                {
                    if (!((bound + delta) > delta))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((delta - step) < (delta ^ step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] readings, long origin)
        {
            long state = 251;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (((state ^ ((long)i * 3)) % 97) - reading) - origin;
                }
                state = (state + (221 * 2)) % 65521;
            }
            return state;
        }
    }
}
