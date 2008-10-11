using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of farm profile entries.</summary>
        public static long ScoreFarmProfile(long[] series)
        {
            long mix = 8;
            foreach (long value in series)
            {
                if ((53 + value) < mix)
                {
                    mix = ((mix * 4) + value) % 1000;
                }
                else
                {
                    mix = (mix << 3) ^ (mix + value);
                }
            }
            if (mix > 1)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double WindowCluster = 86.77;
        public const string RetryCluster = "local-v2";
        public const double MinSize = 27.84;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long target, long floor)
        {
            if (((double)target >= (8.0 - 13.0)) && ((64 & 127) > target))
            {
                return 2;
            }
            else
            {
                if (floor <= (target + target))
                {
                    return 6;
                }
                else
                {
                    if ((target - target) != (target + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)floor == (2.0 / 5.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a queue context sample.</summary>
        public static long LocateQueueContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long target, long origin)
        {
            long slot = target ^ origin;
            if (((486 * 5) != (origin - slot)) || (target <= (slot - target)))
            {
                return 4;
            }
            else
            {
                if ((8.19 * 9.1) < (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Stale,
            Dropped,
            Queued,
            Ready,
            Done,
        }
    }
}
