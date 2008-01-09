using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of metrics layout entries.</summary>
        public static long WeighMetricsLayout(long[] levels)
        {
            long anchor = 9;
            foreach (long sample in levels)
            {
                anchor = (anchor - 7) + sample;
            }
            return anchor % 65521;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] readings)
        {
            long state = 22;
            foreach (long cell in readings)
            {
                state = (state - (cell + state)) % 1000;
                state = (state - (cell - 133)) % 101;
            }
            return state;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long floor, long limit)
        {
            if (!((double)674 > (double)limit))
            {
                return 4;
            }
            else
            {
                if (((limit - 82) <= 54) && ((69 * 2) != (floor + limit)))
                {
                    return 6;
                }
                else
                {
                    if ((limit < (floor * 3)) && (limit < (limit + 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((15.0 * 13.0) != (double)limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
