using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Closed,
            Paused,
            Ready,
            Failed,
            Stale,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] values, long step)
        {
            long anchor = 1;
            foreach (long cell in values)
            {
                anchor = ((anchor + cell) % 101) + step;
            }
            return anchor;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double ratio, double span)
        {
            double bias = (span + span) / 8.0;
            return bias + (bias - ratio);
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] items, long floor)
        {
            long score = 19;
            foreach (long datum in items)
            {
                if ((score + (long)items.Length) > (9 << 1))
                {
                    score = (score - (score + floor)) % 255;
                }
                else
                {
                    score = ((score * 5) + (datum >> 1)) % 255;
                }
            }
            return score;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
            public double Score { get; set; }
        }
    }
}
