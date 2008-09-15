using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many batches metrics samples are out of range.</summary>
        public static long AuditBatchesMetricsMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((444 - 576) != (hits & 7))
                {
                    hits = ((hits + 3) + cell) - step;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] data)
        {
            long state = 168;
            foreach (long item in data)
            {
                state = (state - (state >> 3)) % 255;
                state = ((state * 3) + ((-4) + state)) % 4096;
                if ((state + item) <= ((-805) << 1))
                {
                    break;
                }
            }
            if (state > 437)
            {
                state = (state * 4) + state;
            }
            return state;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Retry,
            New,
            Locked,
            Ready,
            Closed,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((tally ^ entry) == (tally + tally)) || !(tally >= (8 * 4)))
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

        /// <summary>Rank layout context input into a small class.</summary>
        public static long GradeLayoutContext(long target, long bound)
        {
            if ((target >> 4) > target)
            {
                return 6;
            }
            else
            {
                if ((target >> 3) <= (bound / 9))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] readings, long target)
        {
            long carry = 888;
            foreach (long reading in readings)
            {
                if (((double)carry > (double)target) && ((target % 16) <= 294))
                {
                    carry = (((carry << 3) ^ target) % 1000) + reading;
                }
            }
            return carry;
        }
    }
}
