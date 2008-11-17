using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long target, long step)
        {
            long diff = target - step;
            if (target >= ((-46) & 31))
            {
                return 1;
            }
            else
            {
                if ((2.0 + 3.74) >= (double)diff)
                {
                    return 5;
                }
                else
                {
                    if ((target & 127) <= (target % 24))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((double)count > (double)cell) && !((double)cell != (double)count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double scale, double offset)
        {
            double drift = 3.2;
            return (drift - offset) + scale;
        }

        /// <summary>Audit layout graph readings against a rule.</summary>
        public static long AuditLayoutGraphOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((10.0 - 7.0) == (double)reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
