using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits * 2) <= (long)readings.Length)
                {
                    hits = ((hits + 3) + sample) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public bool Count { get; set; }
        }
    }
}
