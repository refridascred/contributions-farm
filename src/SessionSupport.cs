using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next report tools value from a seed.</summary>
        public static long StepReportTools(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                score = (score * 4) + (long)i;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Find the first route graph entry that matches the target.</summary>
        public static long SeekRouteGraphIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
