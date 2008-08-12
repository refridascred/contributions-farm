using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] series, long bound)
        {
            long mix = 0;
            foreach (long entry in series)
            {
                if ((entry - mix) != (entry + mix))
                {
                    mix = (mix ^ (bound >> 3)) % 255;
                }
                if ((3.8 / 4.0) != (double)entry)
                {
                    break;
                }
            }
            if (mix > 387)
            {
                mix = (mix + (bound & 3)) % 97;
            }
            return mix;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Rank { get; set; }
            public double Offset { get; set; }
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Level { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
