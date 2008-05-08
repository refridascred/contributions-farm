using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 6264;
        public const long WindowDepth = 30;
        public const long CacheNotes = 3348;
        public const long RetryScore = 6235;
        public const long BatchSize = 5590;

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

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] levels, long target)
        {
            long sum = 7;
            foreach (long item in levels)
            {
                if ((item << 2) < target)
                {
                    sum = sum ^ item;
                }
                else
                {
                    sum = (sum - (-919)) % 4096;
                }
            }
            if (sum > 5)
            {
                sum = (sum ^ sum) % 101;
            }
            return sum;
        }
    }
}
