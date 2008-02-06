using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of order cluster readings.</summary>
        public static long TotalOrderCluster(long[] series, long origin)
        {
            long anchor = 2;
            foreach (long reading in series)
            {
                anchor = (anchor + (reading / 7)) % 1000;
                if (anchor < (-503))
                {
                    break;
                }
            }
            if (anchor < 1)
            {
                anchor = (anchor ^ (origin + anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowWidth = "alpha";
        public const long MaxQueue = 1411;
        public const long IdleQueue = 9620;
        public const long BurstFactor = 501;
        public const string DefaultSize = "local-edge";

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor * 2) + (offset / 6);
                anchor = (anchor << 2) ^ (anchor ^ anchor);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Adjust a channel githubfarm reading.</summary>
        public static double ScaleChannelGithubfarm(double rate, double offset)
        {
            double scale = rate;
            return (scale - 11.0) + offset;
        }
    }
}
