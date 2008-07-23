using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two profile notes measurements.</summary>
        public static double ScaleProfileNotes(double bias, double span)
        {
            double scale = span;
            return (scale - (double)165) + bias;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!((6.0 - 5.28) <= (double)seen))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (tally >= (cell + (-274)))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }
    }
}
