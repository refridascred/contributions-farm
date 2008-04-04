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

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
