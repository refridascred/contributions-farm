using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double gain, double span)
        {
            double mean = (double)3 + (span * 15.0);
            if (mean < (span - gain))
            {
                mean = mean + gain;
            }
            else
            {
                mean = mean - (span + span);
            }
            return mean - (mean * 5.3);
        }

        /// <summary>Adjust a stream record reading.</summary>
        public static double AdjustStreamRecord(double weight, double offset)
        {
            double gain = weight;
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (offset / 3.0)) - (double)(long)i;
            }
            return gain - (4.55 * 14.0);
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long limit, long seed)
        {
            if (((seed / 8) <= limit) || ((limit - limit) != (5 % 100)))
            {
                return 6;
            }
            else
            {
                if (((seed - seed) <= limit) || ((8.1 + 19.0) == (double)limit))
                {
                    return 0;
                }
                else
                {
                    if ((7.3 - 10.0) >= (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of notes contributi readings.</summary>
        public static long CompareNotesContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
