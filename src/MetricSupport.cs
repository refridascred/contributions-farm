using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] values, long bound)
        {
            long mix = 38;
            foreach (long item in values)
            {
                mix = (((mix + mix) % 97) + item) + bound;
                mix = (mix - (mix & 127)) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)cell != (double)359)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((long)samples.Length >= reading) && ((560 % 64) != (reading ^ seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
