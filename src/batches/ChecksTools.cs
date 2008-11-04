using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit session farm readings against a rule.</summary>
        public static long TallySessionFarmHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((((entry - count) < ((long)values.Length / 5)) && ((9.0 * 4.7) >= (double)count)) && (entry > (count << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long floor, long step)
        {
            if ((step + floor) >= 296)
            {
                return 8;
            }
            else
            {
                if ((step <= 10) || ((floor >> 2) < step))
                {
                    return 3;
                }
                else
                {
                    if ((floor << 3) < (floor << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate metric farm samples.</summary>
        public static long WeighMetricFarm(long[] levels, long origin)
        {
            long acc = 8;
            foreach (long cell in levels)
            {
                if ((cell >> 4) <= (acc + 7))
                {
                    acc = (acc + (origin & 63)) % 101;
                }
            }
            if (acc < 0)
            {
                acc = (acc - (836 * 5)) % 65521;
            }
            return acc;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
