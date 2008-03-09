using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the stream report series from a seed.</summary>
        public static long IterateStreamReport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor * 5) + ((long)i ^ 6);
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Idle,
            Active,
            Closed,
            Failed,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Failed,
            Draft,
            Dropped,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = acc + step;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((datum + datum) < (datum << 1)) || (((94 << 1) < datum) && ((double)datum <= (15.0 - 9.0))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long offset, long target)
        {
            long step = offset ^ target;
            if ((target / 7) >= (offset + step))
            {
                return 5;
            }
            else
            {
                if (!((target ^ step) == (offset + target)))
                {
                    return 0;
                }
                else
                {
                    if (!(offset > (step - 0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
