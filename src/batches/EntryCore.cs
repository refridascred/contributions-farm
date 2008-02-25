using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BaseRecord = "local-1";
        public const long StepFactor = 98;
        public const string DefaultDepth = "fallback-v2";
        public const long IdleSize = 388;

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] data)
        {
            long mix = 3;
            foreach (long sample in data)
            {
                if ((mix - sample) <= 693)
                {
                    mix = ((mix * 2) + (sample >> 1)) % 101;
                }
                else
                {
                    mix = (mix ^ (sample / 3)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
