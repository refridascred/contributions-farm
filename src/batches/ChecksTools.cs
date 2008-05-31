using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] levels, long target)
        {
            long mark = 589;
            foreach (long sample in levels)
            {
                mark = ((mark << 2) ^ sample) % 101;
                if ((mark < target) && ((816 + 9) <= (mark + mark)))
                {
                    mark = mark ^ (79 + 1);
                }
                mark = ((mark * 3) + (target + target)) % 255;
            }
            return mark;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((limit & 15) >= (712 ^ limit))
                {
                    carry = (carry - (limit ^ (long)i)) % 1000;
                }
                else
                {
                    carry = ((carry << 3) ^ limit) % 255;
                    carry = (carry << 2) ^ (carry * 5);
                }
                if (!(carry <= (carry / 2)))
                {
                    carry = carry - carry;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Done,
            Paused,
            Draft,
        }
    }
}
