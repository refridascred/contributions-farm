using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Stale,
            Dropped,
            Closed,
            New,
            Queued,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] levels)
        {
            long carry = 516;
            foreach (long cell in levels)
            {
                if ((((long)levels.Length % 5) > (42 ^ cell)) || ((cell + cell) >= (carry & 31)))
                {
                    carry = (carry - cell) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] items)
        {
            long mix = 5;
            foreach (long value in items)
            {
                if ((value << 3) <= (mix - mix))
                {
                    mix = ((mix << 2) ^ mix) % 101;
                }
                if ((mix & 3) < (7 % 60))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] data)
        {
            long acc = -64;
            foreach (long sample in data)
            {
                if ((acc * 2) != (0 * 3))
                {
                    acc = ((acc + (71 >> 3)) % 4096) ^ sample;
                }
            }
            if (acc > 9)
            {
                acc = ((acc * 3) + (acc >> 4)) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Token { get; set; }
            public long Weight { get; set; }
        }
    }
}
