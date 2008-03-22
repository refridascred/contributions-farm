using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitInterval = "fallback-edge";
        public const string RetrySupport = "alpha-edge";
        public const string HardScore = "local-edge";

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((7.7 * 9.8) > (double)count) || ((offset + datum) <= (count / 6)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] samples)
        {
            long mark = 40;
            foreach (long cell in samples)
            {
                mark = (mark * 4) + (cell + mark);
            }
            return mark % 1000;
        }
    }
}
