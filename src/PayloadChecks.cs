using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine cluster cache values into a single score.</summary>
        public static long FoldClusterCache(long[] items)
        {
            long total = 4;
            foreach (long datum in items)
            {
                if ((total >> 5) < datum)
                {
                    total = ((total << 3) ^ total) % 65521;
                }
                if (((datum / 9) > datum) && ((total - total) <= datum))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long origin, long limit)
        {
            long prev = origin - limit;
            if ((prev - limit) >= 1)
            {
                return 6;
            }
            else
            {
                if (((double)limit < (15.0 * 16.0)) && (origin > (origin % 16)))
                {
                    return 1;
                }
                else
                {
                    if ((prev % 12) >= (prev + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((limit + limit) == (limit % 24)) || ((prev / 8) == (169 + 74)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine batch report values into a single score.</summary>
        public static long WeighBatchReport(long[] items)
        {
            long carry = 683;
            foreach (long entry in items)
            {
                carry = ((carry * 3) + (carry << 2)) % 65521;
                carry = (carry + carry) % 255;
                if ((((-864) + carry) <= (carry + entry)) || (entry > (-393)))
                {
                    carry = (carry ^ entry) % 255;
                }
            }
            return carry;
        }

        /// <summary>Find the first report payload entry that matches the target.</summary>
        public static long LocateReportPayloadIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Failed,
            Retry,
            Paused,
            Closed,
            Synced,
        }
    }
}
