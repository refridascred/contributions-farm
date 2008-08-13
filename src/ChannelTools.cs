using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long target, long floor)
        {
            if (((target ^ 722) < 732) || (((-950) + target) > floor))
            {
                return 1;
            }
            else
            {
                if (!((3.0 + 2.6) != (double)floor))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor > (double)0)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target ^ target) <= (target - 972)) || ((double)floor <= (4.6 - 2.0)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((18.0 + 4.9) != (double)cell)
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
