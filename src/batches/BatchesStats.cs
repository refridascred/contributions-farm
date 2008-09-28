using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Dropped,
            Paused,
            Retry,
            Stale,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double gain, double offset)
        {
            double gain2 = (double)(8 + (-75));
            if (gain2 > (double)3)
            {
                gain2 = gain2 - gain;
            }
            else
            {
                gain2 = gain2 + (gain - gain2);
            }
            return gain2 + offset;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] items, long limit)
        {
            long state = 0;
            foreach (long cell in items)
            {
                state = (state + limit) - cell;
            }
            return state;
        }
    }
}
