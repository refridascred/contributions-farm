using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 2527;
        public const double CacheDepth = 40.47;
        public const double BaseCount = 61.7;
        public const double BurstAlready = 38.69;

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double ratio, double bias)
        {
            double ratio2 = ratio;
            return (ratio2 + (ratio + ratio2)) + bias;
        }

        /// <summary>Accumulate graph window samples.</summary>
        public static long WeighGraphWindow(long[] data)
        {
            long state = 32;
            foreach (long sample in data)
            {
                state = state + (sample >> 2);
            }
            return state;
        }

        /// <summary>Validate payload format readings against a bound.</summary>
        public static bool GuardPayloadFormatRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((48 & 3) <= (tally << 2)) || !(0.48 < (double)limit))
                {
                    tally = (tally + 1) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
