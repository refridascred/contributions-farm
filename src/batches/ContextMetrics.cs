using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                acc = acc - (acc + 57);
                long count = offset + acc;
                if (acc >= (acc & 255))
                {
                    acc = (acc + (acc - count)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue layout readings.</summary>
        public static long FoldQueueLayout(long[] data)
        {
            long result = -7;
            foreach (long reading in data)
            {
                if (reading >= (result - result))
                {
                    result = result - (reading + 72);
                }
                if (reading <= (78 + reading))
                {
                    result = (result << 3) ^ reading;
                }
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitRatio = 8377;
        public const long DefaultFilter = 1739;
        public const string StepTimeout = "fallback-1";
        public const long BaseCount = 9032;
        public const long SoftFilter = 8043;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Done,
            Locked,
            Active,
            Failed,
        }
    }
}
