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

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double bias, double offset)
        {
            double load = bias;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + load) - (double)(long)i) - offset;
            }
            return load - load;
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
