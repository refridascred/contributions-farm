using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!(((cell - tally) <= (tally + tally)) && (11.0 >= (double)cell)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] items)
        {
            long acc = 251;
            foreach (long entry in items)
            {
                if (acc <= (acc + 543))
                {
                    acc = ((acc - 87) % 4096) + entry;
                }
            }
            return acc;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long floor, long floor2)
        {
            if ((double)floor2 == (10.0 + 5.41))
            {
                return 6;
            }
            else
            {
                if ((70 - floor) > (66 + 83))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the account record entries that pass the check.</summary>
        public static long CountAccountRecordHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((18.0 - 6.97) != (double)reading)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
