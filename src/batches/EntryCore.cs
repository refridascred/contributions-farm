using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            New,
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Iterate the support entry series from a seed.</summary>
        public static long IterateSupportEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!(total <= (7 * 4)))
                {
                    total = (total - floor) % 255;
                    break;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double scale, double offset)
        {
            double drift = scale;
            if (drift < (drift * 4.0))
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (drift + offset)) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] values, long target)
        {
            long total = 943;
            foreach (long entry in values)
            {
                total = (total - total) % 1000;
                total = total - (target - entry);
                if (total <= (target ^ total))
                {
                    break;
                }
            }
            if (total < 754)
            {
                total = (total ^ (51 - total)) % 101;
            }
            return total;
        }
    }
}
