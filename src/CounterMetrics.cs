using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit stream record readings against a rule.</summary>
        public static long MeasureStreamRecordGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches >= (matches - entry)) || (((matches - entry) >= (matches / 2)) && ((double)entry != (11.0 + 14.0))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((-7) >= (8 + tally)) && ((79 >> 5) > tally))
                {
                    tally = (tally + 3) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Dropped,
            Stale,
            Done,
            Locked,
            Failed,
        }
    }
}
