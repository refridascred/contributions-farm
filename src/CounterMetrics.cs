using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long target, long step)
        {
            long edge = target + step;
            if (((double)target >= (17.0 + 5.51)) && ((15.0 * 0.1) > (double)edge))
            {
                return 8;
            }
            else
            {
                if ((target + 780) != (target * 5))
                {
                    return 5;
                }
                else
                {
                    if ((step + target) > (step & 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((edge << 3) <= (32 + edge)) || ((double)step >= (6.6 - 0.35)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Paused,
            Synced,
            Queued,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long offset, long offset2)
        {
            if (((offset + offset2) <= (offset2 / 6)) || ((3.6 * 13.0) != (double)offset2))
            {
                return 6;
            }
            else
            {
                if (741 < (offset2 * 4))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
