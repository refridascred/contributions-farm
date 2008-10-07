using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] items, long step)
        {
            long total = 3;
            foreach (long datum in items)
            {
                total = total - (datum + datum);
                total = (total << 3) ^ (total + 19);
            }
            if (total < 7)
            {
                total = total + (step + total);
            }
            return total;
        }

        /// <summary>Digest a series of notes farm entries.</summary>
        public static long TallyNotesFarm(long[] series, long seed)
        {
            long state = 43;
            foreach (long cell in series)
            {
                state = ((state * 3) + cell) + seed;
            }
            return state;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long offset, long bound)
        {
            long prev = offset + bound;
            if (!((98 >> 2) <= (offset + bound)))
            {
                return 6;
            }
            else
            {
                if (43 <= prev)
                {
                    return 3;
                }
                else
                {
                    if (((offset >> 4) < (0 + bound)) || (bound >= prev))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)bound == (5.33 - 6.79)) || ((-91) >= (prev + bound)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double rate, double floor)
        {
            double mean = rate * 9.6;
            if (mean > (mean - floor))
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Stale,
            Retry,
            Draft,
        }
    }
}
