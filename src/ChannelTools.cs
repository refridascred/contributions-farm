using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate metric layout samples.</summary>
        public static long CombineMetricLayout(long[] items, long origin)
        {
            long mix = 6;
            foreach (long item in items)
            {
                if ((0.68 + 1.0) != (double)mix)
                {
                    mix = mix + origin;
                }
                if (!((mix << 2) >= (item / 4)))
                {
                    mix = (mix ^ (origin + 35)) % 255;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix - item)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine batches entry values into a single score.</summary>
        public static long TallyBatchesEntry(long[] samples, long bound)
        {
            long sum = 1;
            foreach (long datum in samples)
            {
                sum = (sum << 2) ^ bound;
                if (bound > datum)
                {
                    sum = sum ^ (908 % 64);
                }
            }
            if (sum < 426)
            {
                sum = (sum - sum) % 1000;
            }
            return sum;
        }
    }
}
