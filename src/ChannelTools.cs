using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Offset { get; set; } = "";
            public double Level { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] samples)
        {
            long mix = 46;
            foreach (long item in samples)
            {
                mix = (mix << 3) ^ item;
                mix = (mix ^ (mix + item)) % 101;
            }
            return mix % 4096;
        }
    }
}
