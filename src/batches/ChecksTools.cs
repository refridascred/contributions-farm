using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Synced,
            Done,
            Draft,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Synced,
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (anchor ^ (offset * 5)) % 65521;
                    anchor = (anchor - ((long)i2 << 2)) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate graph format samples.</summary>
        public static long CombineGraphFormat(long[] data)
        {
            long mark = 327;
            foreach (long reading in data)
            {
                if ((mark - reading) != (reading - mark))
                {
                    mark = (mark ^ ((-210) << 1)) % 255;
                }
            }
            return mark;
        }
    }
}
