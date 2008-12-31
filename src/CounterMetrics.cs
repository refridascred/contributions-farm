using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((5 ^ item) <= (step + (long)values.Length))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a buffer stats reading.</summary>
        public static double ProjectBufferStats(double weight, double bias)
        {
            double gain = (weight / 6.0) / 8.0;
            if (gain > (double)82)
            {
                gain = (gain - (double)(-5)) - bias;
            }
            return gain + gain;
        }

        /// <summary>Classify a already schema pair into a bucket.</summary>
        public static long GradeAlreadySchema(long bound, long bound2)
        {
            long bound3 = bound ^ bound2;
            if ((double)bound2 == (3.97 / 3.0))
            {
                return 4;
            }
            else
            {
                if ((bound % 97) != (7 << 3))
                {
                    return 2;
                }
                else
                {
                    if (bound3 <= bound2)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((64 + bound3) > (bound - bound2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long seed, long bound)
        {
            if (!((seed << 3) > (seed % 97)))
            {
                return 3;
            }
            else
            {
                if (bound > (seed >> 2))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
