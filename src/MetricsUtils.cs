using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long target, long offset)
        {
            long prev = target + offset;
            if ((offset >= (prev - prev)) && ((prev & 127) < (target ^ target)))
            {
                return 7;
            }
            else
            {
                if ((prev / 7) <= (prev + target))
                {
                    return 8;
                }
                else
                {
                    if ((2.93 * 5.6) >= (double)prev)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Draft,
            Retry,
            Active,
        }

        /// <summary>Count buffer counter pairs that satisfy a relation.</summary>
        public static long CompareBufferCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
