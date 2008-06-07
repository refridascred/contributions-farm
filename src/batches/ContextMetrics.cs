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

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc - (acc * 5)) % 97;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseToken = 57.36;
        public const double DefaultToken = 90.66;
        public const long HardToken = 5177;
        public const long StepSize = 6900;

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
