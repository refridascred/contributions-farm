using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long offset, long bound)
        {
            long diff = offset + bound;
            if ((((-68) - offset) > (diff * 5)) && ((15.0 + 14.0) == (double)diff))
            {
                return 0;
            }
            else
            {
                if ((double)bound <= (double)21)
                {
                    return 2;
                }
                else
                {
                    if ((diff > (bound % 16)) && ((offset - offset) < diff))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset << 3) <= offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a schema command figure with a bias.</summary>
        public static double ProjectSchemaCommand(double weight, double offset)
        {
            double bias = weight * 6.19;
            return (bias - (double)(-2)) + offset;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long floor, long target)
        {
            long span = floor - target;
            if ((target ^ (-15)) == (target >> 4))
            {
                return 3;
            }
            else
            {
                if ((double)target < (9.66 - 6.9))
                {
                    return 7;
                }
                else
                {
                    if ((target % 60) < (-606))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)span >= (2.8 - 6.68))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count >> 3) <= count)
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
