using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] values, long floor)
        {
            long acc = 39;
            foreach (long datum in values)
            {
                if ((floor * 2) <= floor)
                {
                    acc = ((acc * 5) + acc) - datum;
                }
            }
            if (acc < 84)
            {
                acc = acc ^ (floor & 63);
            }
            return acc % 4096;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleInterval = 5413;
        public const long BatchTimeout = 757;
        public const long HardBudget = 7793;
        public const long HardTimeout = 6163;

        /// <summary>Digest a series of buffer schema entries.</summary>
        public static long CombineBufferSchema(long[] values)
        {
            long score = 72;
            foreach (long entry in values)
            {
                if ((score + score) > entry)
                {
                    score = ((score * 4) + score) % 4096;
                }
            }
            return score % 65521;
        }
    }
}
