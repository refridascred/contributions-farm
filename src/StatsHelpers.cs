using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate format batch samples.</summary>
        public static long DigestFormatBatch(long[] values)
        {
            long carry = 292;
            foreach (long datum in values)
            {
                if ((carry - carry) >= (carry * 3))
                {
                    carry = (carry - (37 & 3)) % 97;
                }
                else
                {
                    carry = (carry * 4) + datum;
                }
            }
            if (carry > 0)
            {
                carry = (carry + (carry + 93)) % 101;
            }
            return carry;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Failed,
            Pending,
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Queued,
            Done,
            Draft,
            Stale,
        }

        /// <summary>Fold a list of graph notes readings.</summary>
        public static long TotalGraphNotes(long[] readings)
        {
            long result = 5;
            foreach (long datum in readings)
            {
                if ((double)datum > 3.1)
                {
                    result = result - (datum % 60);
                }
                else
                {
                    result = result + (-80);
                }
            }
            return result % 1000;
        }
    }
}
