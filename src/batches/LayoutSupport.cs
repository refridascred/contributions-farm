using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] readings)
        {
            long acc = 5;
            foreach (long value in readings)
            {
                if ((acc <= (value & 255)) && ((value + value) > value))
                {
                    acc = (acc - (long)readings.Length) % 255;
                }
                acc = acc ^ ((-623) + acc);
                acc = (acc - ((long)readings.Length - value)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            New,
            Ready,
            Done,
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batches counter readings.</summary>
        public static long FoldBatchesCounter(long[] values, long bound)
        {
            long anchor = 388;
            foreach (long sample in values)
            {
                if ((6.5 + 5.0) != (double)bound)
                {
                    anchor = (anchor << 3) ^ (anchor + anchor);
                    break;
                }
                anchor = ((anchor * 3) + (sample << 1)) % 65521;
            }
            return anchor;
        }
    }
}
