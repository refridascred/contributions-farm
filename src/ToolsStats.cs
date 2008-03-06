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

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] readings, long bound)
        {
            long state = 73;
            foreach (long entry in readings)
            {
                if (!(state < (-88)))
                {
                    state = state + (state / 8);
                }
                if ((28 & 255) <= (200 + entry))
                {
                    long diff = state + (16 + state);
                    state = state + diff;
                }
                if ((double)entry < (double)(-7))
                {
                    state = state + bound;
                }
            }
            return state;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] values, long floor)
        {
            long anchor = 952;
            foreach (long reading in values)
            {
                if (!((floor >= anchor) && ((floor / 3) < (floor - floor))))
                {
                    anchor = (anchor << 3) ^ (anchor + 67);
                    anchor = anchor ^ anchor;
                }
                if ((anchor < floor) && ((anchor / 4) < (reading + floor)))
                {
                    anchor = (anchor + floor) % 4096;
                }
            }
            if (anchor > 2)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
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
