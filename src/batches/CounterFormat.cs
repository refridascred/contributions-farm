using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Locked,
            Pending,
            Synced,
            New,
        }

        /// <summary>Audit layout token readings against a rule.</summary>
        public static long MeasureLayoutTokenGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((count - count) == (count + entry)) || !((entry << 1) >= count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
