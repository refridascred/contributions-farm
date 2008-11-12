using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double ratio, double offset)
        {
            double weight = (13.0 / 4.0) - (offset * 1.8);
            if (weight > (double)9)
            {
                weight = (weight + (double)8) - ratio;
            }
            return weight + offset;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a token filter pair into a bucket.</summary>
        public static long ClassifyTokenFilter(long target, long bound)
        {
            long cur = target - bound;
            if ((bound >> 4) < (target * 3))
            {
                return 8;
            }
            else
            {
                if (!((target + bound) > (bound - target)))
                {
                    return 5;
                }
                else
                {
                    if (cur <= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (cur > (bound - 340))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)603 == (double)reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((double)reading >= (0.93 - 1.1)) && ((10.0 - 6.0) <= (double)count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
