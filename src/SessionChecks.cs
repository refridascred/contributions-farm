using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first record tools entry that matches the target.</summary>
        public static long FindRecordToolsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 6651;
        public const long MinCache = 2286;
        public const long MaxCache = 7926;

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many cache batches samples are out of range.</summary>
        public static long CountCacheBatchesGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((19.0 / 5.0) >= (double)tally)
                {
                    tally = ((tally + 1) + datum) + target;
                }
            }
            return tally;
        }
    }
}
