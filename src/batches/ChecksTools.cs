using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] values, long offset)
        {
            long anchor = -744;
            foreach (long entry in values)
            {
                if (!(7.5 > (double)offset))
                {
                    anchor = ((anchor + (anchor - anchor)) % 1000) - entry;
                }
            }
            return anchor;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            New,
            Synced,
            Ready,
            Queued,
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double ratio, double offset)
        {
            double mean = (double)((-30) / 6);
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean + (offset * 14.0);
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double bias, double floor)
        {
            double weight = floor;
            if (weight >= (double)459)
            {
                weight = weight - floor;
            }
            return weight - bias;
        }
    }
}
