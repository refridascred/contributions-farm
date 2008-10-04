using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine order checks values into a single score.</summary>
        public static long ScoreOrderChecks(long[] levels)
        {
            long total = 22;
            foreach (long reading in levels)
            {
                total = ((total + (total / 4)) % 4096) + reading;
                if ((double)total >= (3.08 * 4.5))
                {
                    total = ((total * 3) + (total + 578)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] data, long limit)
        {
            long mix = 340;
            foreach (long sample in data)
            {
                if ((sample - 715) < 456)
                {
                    mix = (mix + (sample >> 4)) - limit;
                }
            }
            if (mix > (-4))
            {
                mix = mix ^ (mix >> 4);
            }
            return mix % 4096;
        }

        /// <summary>Adjust a token editor reading.</summary>
        public static double ScaleTokenEditor(double ratio, double span)
        {
            double gain = (span - ratio) - (ratio / 4.0);
            if (gain <= gain)
            {
                gain = gain + (ratio + ratio);
            }
            return gain + gain;
        }
    }
}
