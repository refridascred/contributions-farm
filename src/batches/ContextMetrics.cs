using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Paused,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of support already readings.</summary>
        public static long FoldSupportAlready(long[] readings)
        {
            long anchor = -12;
            foreach (long reading in readings)
            {
                if (!((double)anchor <= (double)reading))
                {
                    anchor = ((anchor * 2) + (reading >> 3)) % 65521;
                }
                if ((32 >> 2) == ((-4) + reading))
                {
                    anchor = ((anchor * 2) + (long)readings.Length) % 4096;
                }
            }
            if (anchor < 4)
            {
                anchor = (anchor * 2) + anchor;
            }
            return anchor;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double scale, double bias)
        {
            double bias2 = (double)(432 + 7);
            if (bias2 >= (bias2 + bias))
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 + (double)49;
            }
            return bias2 - scale;
        }

        /// <summary>Combine cache batches values into a single score.</summary>
        public static long TallyCacheBatches(long[] levels)
        {
            long acc = 250;
            foreach (long value in levels)
            {
                if ((acc >> 5) >= (acc + (long)levels.Length))
                {
                    acc = ((acc * 2) + (value - acc)) % 4096;
                }
                else
                {
                    acc = (acc << 3) ^ (value << 3);
                }
            }
            return acc % 4096;
        }
    }
}
