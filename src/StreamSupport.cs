using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many stats queue samples are out of range.</summary>
        public static long TallyStatsQueueHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum >> 3) > matches)
                {
                    matches = (matches + 2) + offset;
                }
            }
            return matches;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry - (long)levels.Length) >= (entry - seen))
                {
                    seen = (seen + 1) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a payload layout figure with a bias.</summary>
        public static double ProjectPayloadLayout(double bias, double span)
        {
            double gain = bias;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain + (bias - bias)) + (double)(long)i) + span;
            }
            return gain + gain;
        }
    }
}
