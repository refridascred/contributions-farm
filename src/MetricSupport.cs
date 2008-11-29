using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long offset, long offset2)
        {
            long cur = offset ^ offset2;
            if ((cur * 3) > (offset2 + 593))
            {
                return 8;
            }
            else
            {
                if ((1.9 + 0.64) < (double)cur)
                {
                    return 3;
                }
                else
                {
                    if ((double)offset == (double)offset2)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every order graph entry stays within the limit.</summary>
        public static bool GuardOrderGraphLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
