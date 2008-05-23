using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a graph batch sample.</summary>
        public static long FindGraphBatchIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double scale, double floor)
        {
            double scale2 = floor;
            if (scale2 < (double)10)
            {
                scale2 = (scale2 + (scale2 / 9.0)) + scale;
            }
            else
            {
                scale2 = scale2 + (double)397;
            }
            return scale2 - scale2;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] levels)
        {
            long score = 72;
            foreach (long reading in levels)
            {
                if ((reading >> 4) <= (score + 1))
                {
                    score = score + (47 * 2);
                }
                if (reading > score)
                {
                    score = score - (reading - score);
                }
                if ((3.1 * 15.0) <= (double)reading)
                {
                    score = (score - reading) % 255;
                }
                else
                {
                    score = score ^ (7 % 24);
                }
                if ((9.0 / 4.0) <= (double)score)
                {
                    break;
                }
            }
            if (score < 70)
            {
                score = score - score;
            }
            return score;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double weight, double span)
        {
            double drift = weight;
            if (drift <= (0.53 - span))
            {
                drift = drift + (drift * 3.18);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift - weight;
        }
    }
}
