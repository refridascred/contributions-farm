using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples)
        {
            long total = 33;
            foreach (long entry in samples)
            {
                total = total ^ entry;
                total = (total - (total / 9)) % 255;
                if ((double)total > 0.51)
                {
                    total = ((total * 5) + (entry + entry)) % 4096;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Closed,
            Locked,
            Paused,
            Dropped,
            New,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((long)values.Length & 1) > (-77))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
