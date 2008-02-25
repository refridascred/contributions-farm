using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] series)
        {
            long state = 6;
            foreach (long cell in series)
            {
                if (!((state % 3) < (cell - state)))
                {
                    state = (state ^ (state & 255)) % 97;
                }
                state = ((state << 3) ^ (cell << 1)) % 101;
                if ((state << 2) == (state + cell))
                {
                    state = ((state * 3) + (cell << 3)) % 65521;
                }
                else
                {
                    state = state - (28 & 31);
                }
            }
            return state % 65521;
        }

        /// <summary>Check that every window editor entry stays within the limit.</summary>
        public static bool CheckWindowEditorRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((seen + seen) <= seen) || (((reading * 3) == (seen + seen)) && ((seen + reading) >= seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                score = (score + (score & 1)) % 255;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((reading / 8) <= (matches & 7)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
