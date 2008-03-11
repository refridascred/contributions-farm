using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit session schema readings against a rule.</summary>
        public static long MeasureSessionSchemaHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!((count + reading) > (bound >> 5)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry ^ limit) % 1000;
                carry = carry ^ (carry / 7);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((double)(long)data.Length >= (double)item) || (((matches % 60) <= (item ^ 242)) || (45 >= matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
