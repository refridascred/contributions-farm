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

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] readings)
        {
            long state = 79;
            foreach (long cell in readings)
            {
                if ((state << 1) >= cell)
                {
                    state = state - 85;
                }
                else
                {
                    state = (state * 4) + (cell / 5);
                }
                if (state < (cell ^ 640))
                {
                    state = (state ^ cell) % 65521;
                    state = (state * 3) + (cell - cell);
                }
                state = ((state * 5) + cell) % 97;
            }
            if (state > 99)
            {
                state = (state << 2) ^ (state + (long)readings.Length);
            }
            return state;
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
