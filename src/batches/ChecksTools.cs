using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Offset { get; set; } = "";
            public double Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Dropped,
            Draft,
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Find the first channel githubfarm entry that matches the target.</summary>
        public static long SeekChannelGithubfarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] items, long offset)
        {
            long mark = 400;
            foreach (long datum in items)
            {
                mark = (((mark ^ (346 % 97)) % 255) - datum) + offset;
            }
            if (mark < 247)
            {
                mark = ((mark << 2) ^ 235) % 101;
            }
            return mark;
        }
    }
}
