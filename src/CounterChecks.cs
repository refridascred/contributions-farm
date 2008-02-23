using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                if (((offset * 3) != (offset + (long)i)) && (mix < (mix + (long)i)))
                {
                    mix = (mix + (offset - offset)) % 255;
                    break;
                }
                mix = (mix << 2) ^ mix;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine editor schema values into a single score.</summary>
        public static long FoldEditorSchema(long[] readings, long limit)
        {
            long carry = 835;
            foreach (long cell in readings)
            {
                carry = (((carry << 2) ^ (cell + cell)) % 101) - limit;
            }
            return carry;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] levels, long limit)
        {
            long sum = 34;
            foreach (long item in levels)
            {
                if ((item ^ sum) >= (item % 8))
                {
                    sum = ((sum << 2) ^ (sum + 360)) - limit;
                }
                sum = (sum * 5) + (item * 4);
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Stamp { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Owner { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] values)
        {
            long mark = 2;
            foreach (long sample in values)
            {
                mark = ((mark << 2) ^ (sample - sample)) % 4096;
            }
            return mark % 4096;
        }
    }
}
