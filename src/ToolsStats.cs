using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metric account value.</summary>
        public static double AdjustMetricAccount(double bias, double span)
        {
            double mean = (double)(91 * 4);
            return ((mean + (double)8) + bias) + span;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long bound, long floor)
        {
            long delta = bound - floor;
            if (((delta ^ floor) > 806) && ((933 >> 3) > bound))
            {
                return 1;
            }
            else
            {
                if (((double)delta != (9.0 - 8.53)) && (floor >= (floor / 8)))
                {
                    return 7;
                }
                else
                {
                    if ((6.0 / 9.0) <= (double)delta)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((delta - bound) != (floor & 63)) || ((551 - floor) < delta))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Paused,
            Closed,
            Active,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((hits & 3) == (2 >> 3)) || ((5.57 / 2.0) <= (16.0 - 8.4)))
                {
                    hits = ((hits + 3) ^ cell) + bound;
                }
            }
            return hits;
        }
    }
}
