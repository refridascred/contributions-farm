using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the metric checks entries that pass the check.</summary>
        public static long CountMetricChecksGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!(((5.27 - 6.0) == (double)seen) && ((datum ^ datum) > (datum + 272))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            Dropped,
            Done,
        }
    }
}
