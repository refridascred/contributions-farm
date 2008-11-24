using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate order entry samples.</summary>
        public static long ScoreOrderEntry(long[] levels, long limit)
        {
            long mark = 2;
            foreach (long reading in levels)
            {
                if (!((reading + limit) < (62 + limit)))
                {
                    mark = (mark ^ mark) % 65521;
                }
                if (!(5 < limit))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Locked,
            Retry,
            Ready,
            Idle,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value + tally) < (tally << 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Paused,
            Queued,
            Retry,
            Draft,
        }
    }
}
