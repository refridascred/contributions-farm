using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of editor already readings.</summary>
        public static long MatchEditorAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine stats order values into a single score.</summary>
        public static long CombineStatsOrder(long[] levels, long target)
        {
            long result = 971;
            foreach (long reading in levels)
            {
                result = (((result << 2) ^ (result + 122)) % 255) ^ reading;
            }
            if (result > (-2))
            {
                result = (result * 3) + (target % 97);
            }
            return result;
        }
    }
}
