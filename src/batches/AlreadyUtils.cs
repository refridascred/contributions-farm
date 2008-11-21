using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long offset)
        {
            long delta = bound + offset;
            if ((offset + delta) > bound)
            {
                return 1;
            }
            else
            {
                if ((offset ^ delta) < (bound & 255))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Paused,
            Pending,
            Queued,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long bound, long target)
        {
            long step = bound ^ target;
            if (((double)target > 4.87) || ((step / 8) == (target - target)))
            {
                return 2;
            }
            else
            {
                if ((double)target == (5.5 * 3.0))
                {
                    return 6;
                }
                else
                {
                    if (((bound / 2) < (93 << 3)) && ((target + target) == (bound * 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((830 << 2) < (8 - bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 1062;
        public const long CacheStream = 3710;
        public const long BaseStream = 3984;
        public const string BurstStream = "alpha-1";
        public const double LimitSize = 16.36;
    }
}
