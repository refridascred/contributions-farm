using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long offset, long limit)
        {
            long offset2 = offset - limit;
            if (((double)offset == (5.6 + 9.18)) && ((offset % 2) >= offset))
            {
                return 4;
            }
            else
            {
                if (((offset * 4) <= (offset + offset2)) && ((limit >> 4) < (offset2 << 2)))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit > (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((offset - offset2) < limit) && ((limit - offset2) <= offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every order stats entry stays within the limit.</summary>
        public static bool VerifyOrderStatsRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
