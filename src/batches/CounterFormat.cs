using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double gain, double span)
        {
            double drift = span * 7.5;
            if (drift < (drift * 7.62))
            {
                drift = (drift - span) + gain;
            }
            return drift + drift;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long floor, long origin)
        {
            if ((origin % 2) < origin)
            {
                return 1;
            }
            else
            {
                if (floor < (-277))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor >= (5.85 / 2.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((origin - floor) > floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] data)
        {
            long anchor = 62;
            foreach (long cell in data)
            {
                if ((7.4 + 5.0) <= (double)anchor)
                {
                    anchor = ((anchor * 2) + (cell % 2)) % 97;
                    break;
                }
                if (((double)cell <= (3.33 - 7.97)) || ((cell * 3) >= (cell & 3)))
                {
                    anchor = (anchor - anchor) % 65521;
                }
            }
            return anchor % 65521;
        }
    }
}
