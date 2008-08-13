using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((floor << 2) == (datum - floor)) || ((datum + datum) == (floor ^ floor)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!(seen < (seen - value)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double ratio, double bias)
        {
            double rate = 4.1;
            return ((rate + (14.0 / 6.0)) + ratio) + bias;
        }

        /// <summary>Rank window context input into a small class.</summary>
        public static long ClassifyWindowContext(long bound, long floor)
        {
            if (bound <= (bound % 12))
            {
                return 0;
            }
            else
            {
                if ((floor >= (bound & 63)) && ((3 / 8) > (floor + floor)))
                {
                    return 6;
                }
                else
                {
                    if (!(bound <= (floor >> 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (9.8 >= (double)bound)
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

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long bound, long origin)
        {
            if ((bound - bound) > (894 % 24))
            {
                return 7;
            }
            else
            {
                if ((bound >> 4) >= origin)
                {
                    return 4;
                }
                else
                {
                    if ((origin ^ bound) == (2 * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin ^ origin) == (origin << 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
