using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] values, long floor)
        {
            long acc = 8;
            foreach (long item in values)
            {
                acc = ((acc * 3) + (item % 16)) - floor;
                acc = acc ^ (acc * 2);
            }
            if (acc > 819)
            {
                acc = (acc * 2) + (acc * 3);
            }
            return acc;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((bound < (bound * 2)) && (((reading - bound) > (reading ^ reading)) && ((8 + bound) <= 0)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
