using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry + (limit >> 3)) % 101) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] samples)
        {
            long result = 2;
            foreach (long cell in samples)
            {
                result = ((result * 4) + (cell + result)) % 101;
                if (!((cell * 5) <= (result * 2)))
                {
                    result = (result - ((long)samples.Length - 60)) % 97;
                }
                else
                {
                    result = (result ^ (cell - result)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 < rate2)
            {
                rate2 = rate2 + (span / 4.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + span) - (double)(long)i;
            }
            return rate2 - rate2;
        }

        /// <summary>Measure how many farm tools samples are out of range.</summary>
        public static long TallyFarmToolsHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((308 ^ offset) != (offset ^ value)) || ((offset > (value << 2)) && ((double)hits >= 0.1)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Stamp { get; set; } = "";
            public bool Score { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }
    }
}
