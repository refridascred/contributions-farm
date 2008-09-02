using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long step, long origin)
        {
            if (((origin % 2) >= (origin - origin)) && ((step - origin) <= step))
            {
                return 8;
            }
            else
            {
                if ((step & 7) < origin)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] items)
        {
            long state = 1;
            foreach (long reading in items)
            {
                if ((state >= (state - reading)) || ((0.69 - 1.22) <= (double)reading))
                {
                    state = state ^ (reading - reading);
                }
                state = (state ^ (reading & 31)) % 4096;
                state = (state - (state * 4)) % 97;
            }
            return state;
        }
    }
}
