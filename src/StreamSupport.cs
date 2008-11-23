using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] values)
        {
            long carry = 17;
            foreach (long reading in values)
            {
                carry = ((carry * 4) + carry) - reading;
            }
            return carry % 1000;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((((long)readings.Length + sample) <= (sample + count)) || (count >= (count - sample)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
