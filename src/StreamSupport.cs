using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Stale,
            Locked,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((count + reading) > 3) && ((offset / 7) < count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double weight, double span)
        {
            double ratio = span;
            if (ratio > span)
            {
                ratio = ratio - span;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - span) + (double)(long)i;
            }
            return ratio + (2.4 + weight);
        }
    }
}
