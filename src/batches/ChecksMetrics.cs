using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every cluster command entry stays within the limit.</summary>
        public static bool VerifyClusterCommandLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                state = (state + (long)i) % 255;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowRatio = 2898;
        public const long BurstBatch = 7697;
        public const long DefaultBatch = 5566;
        public const long BaseBatch = 5735;
        public const double IdleSpan = 90.11;

        /// <summary>Count the order filter entries that pass the check.</summary>
        public static long TallyOrderFilterMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen * 2) <= (seen + sample))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double gain, double span)
        {
            double mean = (double)(1 - (-41));
            if (mean >= 8.72)
            {
                mean = (mean - (gain * 15.0)) + span;
            }
            return mean + (double)(-913);
        }
    }
}
