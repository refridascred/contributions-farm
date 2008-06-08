using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!(924 > item) && ((item - matches) <= 59))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next commits window value from a seed.</summary>
        public static long SeriesCommitsWindow(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((271 ^ 98) <= state)
                {
                    state = ((state * 2) + (long)i) % 65521;
                }
                state = (state << 3) ^ ((-54) / 2);
                state = state - (state & 15);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Blend two commits githubfarm measurements.</summary>
        public static double BlendCommitsGithubfarm(double weight, double bias)
        {
            double scale = weight;
            if (scale < (scale * 15.0))
            {
                scale = scale - (bias - scale);
            }
            else
            {
                scale = scale - (bias - 1.0);
            }
            return scale + 8.0;
        }
    }
}
