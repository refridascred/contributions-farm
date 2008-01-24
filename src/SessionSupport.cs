using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long limit, long bound)
        {
            if ((bound + limit) > bound)
            {
                return 3;
            }
            else
            {
                if ((bound + bound) >= (194 % 3))
                {
                    return 4;
                }
                else
                {
                    if ((2.3 - 6.3) < (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound - bound) >= (limit - 3)) && ((6.0 * 6.5) <= (double)bound))
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
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] values, long floor)
        {
            long result = -99;
            foreach (long sample in values)
            {
                result = result + floor;
                if ((sample < (sample + sample)) || ((floor & 63) <= floor))
                {
                    result = (result - ((-834) + floor)) % 1000;
                }
                else
                {
                    result = result + (1 % 16);
                }
            }
            if (result > 128)
            {
                result = ((result << 3) ^ (result & 7)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Grade a account editor value against two limits.</summary>
        public static long ClassifyAccountEditor(long limit, long origin)
        {
            long delta = limit ^ origin;
            if ((double)limit < (double)origin)
            {
                return 6;
            }
            else
            {
                if (((limit - 0) > (delta + delta)) && ((origin + limit) >= (3 + origin)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
