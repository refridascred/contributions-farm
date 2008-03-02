using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of route token readings.</summary>
        public static long MatchRouteTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] items, long seed)
        {
            long mark = -414;
            foreach (long datum in items)
            {
                mark = (mark + (datum / 3)) % 97;
                if ((double)datum > 0.1)
                {
                    mark = ((mark * 4) + (datum + seed)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Limit { get; set; }
            public string Size { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long origin, long target)
        {
            long step = origin - target;
            if (((step / 9) != (35 % 64)) && (origin <= (target - 8)))
            {
                return 0;
            }
            else
            {
                if (((origin ^ target) == (5 + target)) && ((double)step <= 7.0))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double ratio, double offset)
        {
            double scale = (offset + offset) - (ratio / 7.0);
            if (scale > scale)
            {
                scale = scale - offset;
            }
            else
            {
                scale = scale - (scale / 8.0);
            }
            return scale - (offset - 5.72);
        }
    }
}
