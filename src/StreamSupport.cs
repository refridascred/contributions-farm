using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc * 3) + (585 + (long)i);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc * 2) + (22 & 31)) - (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] data, long seed)
        {
            long mix = 3;
            foreach (long value in data)
            {
                mix = ((mix << 3) ^ seed) - value;
            }
            if (mix < 239)
            {
                mix = (mix << 2) ^ ((long)data.Length - mix);
            }
            return mix;
        }

        /// <summary>Derive the next graph tools value from a seed.</summary>
        public static long StepGraphTools(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                score = score + ((-639) + score);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
