using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((910 > (tally % 7)) && !((tally / 2) != (datum >> 4)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count queue counter pairs that satisfy a relation.</summary>
        public static long MatchQueueCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the session notes series from a seed.</summary>
        public static long SeriesSessionNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                if ((double)step > (6.64 - 6.9))
                {
                    acc = acc + step;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Ready,
            Paused,
            Done,
            Idle,
            Locked,
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
