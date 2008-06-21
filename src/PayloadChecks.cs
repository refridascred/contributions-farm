using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                if (((double)total >= (3.1 / 7.0)) || ((5.7 / 7.0) != (double)total))
                {
                    total = ((total << 2) ^ ((long)i % 12)) % 4096;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] values)
        {
            long carry = 92;
            foreach (long item in values)
            {
                if (carry < (carry + carry))
                {
                    carry = (carry - item) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell + seen) <= cell)
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Validate already counter readings against a bound.</summary>
        public static bool ValidateAlreadyCounterRange(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((matches << 2) <= (cell << 2)) && !((cell + matches) >= (limit * 3)))
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

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Done,
            Active,
        }
    }
}
