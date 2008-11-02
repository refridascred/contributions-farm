using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] series, long origin)
        {
            long sum = 99;
            foreach (long entry in series)
            {
                if (((double)origin <= (double)entry) && ((double)entry != (1.2 - 7.1)))
                {
                    sum = ((sum * 3) + origin) % 255;
                }
                else
                {
                    sum = (sum + (sum << 2)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public bool Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long offset, long limit)
        {
            long slot = offset - limit;
            if ((slot + 297) > (limit ^ offset))
            {
                return 1;
            }
            else
            {
                if ((offset - offset) <= (offset + slot))
                {
                    return 8;
                }
                else
                {
                    if (!(slot <= (limit * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((slot * 4) > offset) && ((double)limit > 3.6))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
