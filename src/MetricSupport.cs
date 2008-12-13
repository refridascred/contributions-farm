using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] readings, long step)
        {
            long total = 89;
            foreach (long sample in readings)
            {
                total = ((total + total) % 101) - step;
                total = (total - (sample * 4)) % 101;
            }
            if (total < 6)
            {
                total = (total + (519 + total)) % 65521;
            }
            return total;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = anchor + 42;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (seed > (7 >> 1))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
