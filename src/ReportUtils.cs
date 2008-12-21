using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)bound < (4.2 + 15.0))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Count the token checks entries that pass the check.</summary>
        public static long MeasureTokenChecksMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + 305) >= (0 - 779))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Draft,
            Synced,
            Failed,
            Queued,
            Done,
        }

        /// <summary>Derive the next notes farm value from a seed.</summary>
        public static long RollNotesFarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                long count = carry + 1;
                if (((carry - step) == (485 + count)) && ((carry + count) > step))
                {
                    carry = (carry ^ (step + step)) % 97;
                    count = (count - (count / 6)) % 97;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long origin, long target)
        {
            if ((origin % 5) > (origin << 1))
            {
                return 6;
            }
            else
            {
                if ((origin << 2) <= origin)
                {
                    return 2;
                }
                else
                {
                    if ((17.0 + 8.5) > (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
