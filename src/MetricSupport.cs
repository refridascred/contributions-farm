using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] levels, long bound)
        {
            long mix = 878;
            foreach (long datum in levels)
            {
                mix = (mix - (bound & 31)) % 101;
                if ((1 + bound) == (datum << 1))
                {
                    mix = (mix << 3) ^ (bound & 255);
                }
                else
                {
                    mix = (mix ^ (datum + mix)) % 4096;
                }
            }
            if (mix < 1)
            {
                mix = (mix - (712 + bound)) % 101;
            }
            return mix;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
