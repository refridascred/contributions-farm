using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long target, long seed)
        {
            long delta = target - seed;
            if ((delta >> 2) == (8 + delta))
            {
                return 5;
            }
            else
            {
                if ((3.4 - 1.8) == (double)delta)
                {
                    return 1;
                }
                else
                {
                    if (((seed & 7) >= delta) || ((9.16 / 2.0) >= (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Synced,
            Locked,
            Queued,
            Paused,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long seed, long origin)
        {
            long bound = seed + origin;
            if ((7 - seed) < (seed ^ 427))
            {
                return 6;
            }
            else
            {
                if (((origin - 930) >= seed) && ((double)origin > (5.1 + 3.2)))
                {
                    return 3;
                }
                else
                {
                    if ((6.3 + 2.1) == (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((seed / 4) > (seed << 3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((8.0 * 1.0) >= (double)value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
