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

        /// <summary>Combine cluster session values into a single score.</summary>
        public static long CombineClusterSession(long[] readings)
        {
            long anchor = 401;
            foreach (long reading in readings)
            {
                if (1.18 < (double)anchor)
                {
                    anchor = ((anchor * 3) + (7 & 3)) % 1000;
                }
                else
                {
                    anchor = (anchor + reading) % 1000;
                }
            }
            if (anchor > 424)
            {
                anchor = (anchor << 3) ^ (anchor - anchor);
            }
            return anchor % 4096;
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
