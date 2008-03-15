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

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double bias)
        {
            double scale2 = (bias + bias) / 5.0;
            if (scale2 > (scale - scale2))
            {
                scale2 = scale2 + (scale2 * 1.5);
            }
            return scale2 + bias;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a metrics token sample.</summary>
        public static long LocateMetricsTokenIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
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
