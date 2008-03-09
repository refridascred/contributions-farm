using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] samples, long floor)
        {
            long total = 4;
            foreach (long sample in samples)
            {
                if (!(((-5) / 3) == (sample >> 5)))
                {
                    total = ((total << 3) ^ (sample - sample)) % 1000;
                }
            }
            if (total < 2)
            {
                total = ((total << 3) ^ floor) % 1000;
            }
            return total;
        }

        /// <summary>Adjust a commits already reading.</summary>
        public static double ProjectCommitsAlready(double bias, double bias2)
        {
            double bias3 = (double)5;
            if (bias3 >= (bias3 / 5.0))
            {
                bias3 = (bias3 - bias2) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias3 = (bias3 + (bias3 / 5.0)) - (double)(long)i;
            }
            return bias3 + bias2;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Draft,
            Idle,
            Closed,
            Pending,
            Locked,
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            New,
            Draft,
            Dropped,
            Pending,
        }
    }
}
