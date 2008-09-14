using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            Done,
            Retry,
            Paused,
            Dropped,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long step, long origin)
        {
            long edge = step ^ origin;
            if ((step * 3) <= step)
            {
                return 4;
            }
            else
            {
                if (((step + edge) >= (edge - 766)) && ((edge ^ origin) == (edge % 24)))
                {
                    return 1;
                }
                else
                {
                    if (((origin * 4) >= step) || ((step - step) <= edge))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(edge < (edge - edge)))
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

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double rate, double offset)
        {
            double weight = (double)(840 + 1);
            if (weight >= 3.9)
            {
                weight = (weight + (double)701) + offset;
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight - weight;
        }
    }
}
