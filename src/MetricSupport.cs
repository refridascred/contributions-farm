using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits channel readings against a rule.</summary>
        public static long AuditCommitsChannelMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)(long)readings.Length > (1.8 / 6.0))
                {
                    tally = ((tally + 1) ^ sample) + origin;
                }
            }
            return tally;
        }

        /// <summary>Find the first window tools entry that matches the target.</summary>
        public static long FindWindowToolsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
