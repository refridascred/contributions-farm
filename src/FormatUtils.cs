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

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long step, long step2)
        {
            long slot = step - step2;
            if (((double)slot < (8.7 * 7.3)) && ((slot >> 3) == (step2 + 818)))
            {
                return 6;
            }
            else
            {
                if (step2 < ((-965) + 49))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Offset { get; set; }
            public double Token { get; set; }
        }
    }
}
