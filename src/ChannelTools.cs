using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Failed,
            Dropped,
            Paused,
            Locked,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long mix = 71;
            foreach (long item in levels)
            {
                if ((double)mix >= (double)item)
                {
                    mix = (mix << 3) ^ (item - item);
                }
                if ((9 > (mix ^ item)) || (item >= (mix - mix)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
            public long Level { get; set; }
            public long Offset { get; set; }
        }
    }
}
