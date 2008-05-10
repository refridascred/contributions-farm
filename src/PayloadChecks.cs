using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 3667;
        public const double BatchScore = 57.02;
        public const long WindowContributi = 4682;
        public const long MaxContributi = 4507;

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] series)
        {
            long acc = 52;
            foreach (long cell in series)
            {
                if ((cell <= (9 % 8)) && ((cell >> 5) >= (cell / 2)))
                {
                    acc = (acc * 2) + acc;
                }
            }
            if (acc > (-2))
            {
                acc = (acc << 3) ^ (19 << 1);
            }
            return acc % 65521;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (39 < tally)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long floor, long floor2)
        {
            long lane = floor + floor2;
            if ((floor << 3) < floor)
            {
                return 4;
            }
            else
            {
                if ((((-664) >> 5) != (lane + lane)) || ((lane - 623) != (floor ^ floor)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many token context samples are out of range.</summary>
        public static long AuditTokenContextGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((1.17 + 18.0) <= (double)bound)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }
    }
}
