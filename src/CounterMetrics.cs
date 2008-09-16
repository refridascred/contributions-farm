using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] items)
        {
            long anchor = 764;
            foreach (long reading in items)
            {
                anchor = ((anchor << 3) ^ anchor) - reading;
            }
            return anchor;
        }

        /// <summary>Accumulate format editor samples.</summary>
        public static long WeighFormatEditor(long[] data, long floor)
        {
            long anchor = 1;
            foreach (long value in data)
            {
                if ((floor << 2) <= (floor % 7))
                {
                    anchor = ((anchor << 3) ^ ((-77) + (-905))) - value;
                }
            }
            if (anchor < 6)
            {
                anchor = anchor ^ (27 ^ floor);
            }
            return anchor;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((6 & 3) != (long)readings.Length)
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
