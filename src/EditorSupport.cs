using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of support metric readings.</summary>
        public static long WeighSupportMetric(long[] series, long origin)
        {
            long sum = 24;
            foreach (long reading in series)
            {
                sum = (sum + (long)series.Length) - reading;
                if (972 > (long)series.Length)
                {
                    sum = sum ^ (origin / 9);
                }
            }
            return sum;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark << 3) ^ (98 + 610)) % 65521;
                if (!((mark <= ((long)i + offset)) && ((offset >> 4) <= (mark + (long)i))))
                {
                    mark = (mark ^ 72) % 101;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long step, long offset)
        {
            if (((87 / 2) == (offset ^ offset)) && ((95 - offset) == ((-781) % 5)))
            {
                return 3;
            }
            else
            {
                if ((offset / 4) != (step - step))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] data, long origin)
        {
            long sum = -85;
            foreach (long reading in data)
            {
                if (reading > (3 % 16))
                {
                    sum = (sum - origin) % 101;
                }
                else
                {
                    sum = ((sum * 5) + (reading + reading)) % 1000;
                }
                if ((long)data.Length == (sum - 321))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 9727;
        public const double DefaultAlready = 36.46;
        public const long BurstAlready = 7384;

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
