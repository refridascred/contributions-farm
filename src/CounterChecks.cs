using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry << 2) ^ carry) % 97;
                carry = (carry - (limit << 3)) % 255;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] levels)
        {
            long mix = -74;
            foreach (long item in levels)
            {
                if ((7.84 / 2.0) == (double)item)
                {
                    mix = mix + (mix / 8);
                }
                else
                {
                    mix = ((mix << 2) ^ ((long)levels.Length + mix)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((double)(long)i < 20.0)
                {
                    continue;
                }
                carry = (carry ^ floor) % 1000;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Derive the next metrics context value from a seed.</summary>
        public static long RollMetricsContext(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    long step = (offset ^ sum) >> 3;
                    sum = ((sum << 2) ^ (6 - step)) + (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc + acc) % 101;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
