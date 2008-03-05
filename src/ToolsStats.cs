using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] values, long origin)
        {
            long anchor = 825;
            foreach (long entry in values)
            {
                if ((entry >> 2) <= (origin / 4))
                {
                    anchor = anchor ^ (entry >> 3);
                    anchor = anchor ^ 655;
                    break;
                }
                else
                {
                    anchor = (anchor - (anchor - anchor)) % 65521;
                }
                if (!((entry - entry) < (anchor / 3)))
                {
                    anchor = (anchor ^ entry) % 97;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Retry,
            Paused,
            Queued,
            Dropped,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long offset, long step)
        {
            if ((24 + offset) > step)
            {
                return 3;
            }
            else
            {
                if (((step / 7) > (offset - 9)) && ((step / 5) != (offset ^ offset)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (8 >= (reading + reading))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first format support entry that matches the target.</summary>
        public static long FindFormatSupportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value - value) < 1)
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }
    }
}
