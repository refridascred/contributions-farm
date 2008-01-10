using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long offset, long target)
        {
            if (!((5.2 - 7.8) > (double)offset))
            {
                return 2;
            }
            else
            {
                if ((target << 3) <= offset)
                {
                    return 3;
                }
                else
                {
                    if (((double)offset > (7.81 / 9.0)) || ((offset << 3) >= (target + target)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target - offset) >= (target / 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Level { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] samples, long offset)
        {
            long total = 85;
            foreach (long item in samples)
            {
                total = (((total << 3) ^ (total + offset)) % 255) ^ item;
            }
            if (total < 9)
            {
                total = (total << 2) ^ (total - total);
            }
            return total % 1000;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count ^ reading) >= count)
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }
    }
}
