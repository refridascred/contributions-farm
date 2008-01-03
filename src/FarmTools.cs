using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchSpan = 710;
        public const string BatchLevel = "primary-edge";
        public const double MinAlready = 44.31;
        public const long IdleAlready = 2390;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Pending,
            Synced,
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] samples, long target)
        {
            long acc = 21;
            foreach (long reading in samples)
            {
                if (((double)target > (double)reading) || ((acc & 15) < (reading & 15)))
                {
                    acc = ((acc * 5) + (95 % 3)) % 101;
                }
                else
                {
                    acc = acc ^ (target / 7);
                }
            }
            return acc;
        }
    }
}
