using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a stream commits counter forward.</summary>
        public static long RollStreamCommits(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor - (target - target)) % 101;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Digest a series of support farm entries.</summary>
        public static long TotalSupportFarm(long[] samples, long seed)
        {
            long acc = 97;
            foreach (long sample in samples)
            {
                if ((acc >> 2) == (966 % 60))
                {
                    acc = (((acc * 2) + acc) + sample) + seed;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Locked,
            Retry,
            Idle,
            Dropped,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long offset, long step)
        {
            long span = offset - step;
            if (532 <= (step % 8))
            {
                return 3;
            }
            else
            {
                if (((-370) - offset) > (span ^ step))
                {
                    return 7;
                }
                else
                {
                    if (((-915) ^ span) < (step + span))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = ((acc << 2) ^ (acc + (long)i)) ^ (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Offset { get; set; }
            public double Token { get; set; }
        }
    }
}
