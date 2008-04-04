using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "stable-1";
        public const double LimitCount = 30.12;
        public const string SoftWidth = "staging-edge";

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] items)
        {
            long mix = 3;
            foreach (long cell in items)
            {
                mix = (((mix << 3) ^ (mix + (-53))) % 255) + cell;
                mix = (mix + mix) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] data, long offset)
        {
            long carry = 7;
            foreach (long cell in data)
            {
                if ((cell - cell) > (-4))
                {
                    carry = (carry ^ offset) % 255;
                }
                else
                {
                    carry = carry + (cell + offset);
                }
            }
            return carry;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double scale, double bias)
        {
            double load = (bias * 8.1) - scale;
            return load + scale;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            Pending,
            Paused,
            Stale,
        }
    }
}
