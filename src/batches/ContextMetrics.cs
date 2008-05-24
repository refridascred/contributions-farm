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

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
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
