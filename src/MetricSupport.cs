using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double rate, double span)
        {
            double gain = (double)((-3) % 100);
            if (gain > (gain * 2.0))
            {
                gain = gain - (span - rate);
            }
            return gain - gain;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batch token readings.</summary>
        public static long ScoreBatchToken(long[] levels, long seed)
        {
            long mix = 0;
            foreach (long value in levels)
            {
                if ((mix / 4) < (mix << 1))
                {
                    mix = ((mix << 2) ^ (value >> 3)) % 255;
                }
                if ((seed + mix) >= (30 * 4))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
