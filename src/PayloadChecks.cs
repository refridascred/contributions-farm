using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                long lane = 548;
                if (limit <= (54 + limit))
                {
                    result = (result - lane) % 97;
                }
                lane = (lane ^ 859) % 1000;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
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

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
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

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long floor, long seed)
        {
            if ((581 < (seed + seed)) && ((floor - floor) >= (504 + 20)))
            {
                return 5;
            }
            else
            {
                if ((8.0 + 4.6) == (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
