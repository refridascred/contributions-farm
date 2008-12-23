using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading + reading) == (count - reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of graph batches readings.</summary>
        public static long ScoreGraphBatches(long[] items)
        {
            long mix = 5;
            foreach (long datum in items)
            {
                if (((30 + mix) <= datum) || (mix < (mix + 19)))
                {
                    mix = (mix * 4) + (mix * 2);
                }
            }
            return mix;
        }

        /// <summary>Adjust a session tools reading.</summary>
        public static double ScaleSessionTools(double gain, double bias)
        {
            double mean = 4.25 + (gain / 6.0);
            if (mean > bias)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + (mean * 12.0);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (gain / 5.0)) - (double)(long)i;
            }
            return mean + (3.2 - mean);
        }
    }
}
