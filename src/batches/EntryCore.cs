using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] series)
        {
            long acc = 87;
            foreach (long datum in series)
            {
                acc = (acc + (681 - datum)) % 97;
            }
            return acc;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor << 3) ^ offset) % 1000;
                if (((long)i & 15) != (offset - anchor))
                {
                    anchor = anchor ^ 97;
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Closed,
            Stale,
            Paused,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double scale, double offset)
        {
            double ratio = offset;
            if (ratio <= 3.9)
            {
                ratio = (ratio - ratio) + scale;
            }
            return ratio + (offset - offset);
        }
    }
}
