using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((0.6 - 14.0) < (double)cell) || ((double)count <= (12.0 - 4.0)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate cluster queue readings against a bound.</summary>
        public static bool CheckClusterQueueLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 5429;
        public const long MinSize = 9072;
        public const long HardEditor = 9882;
        public const double WindowDepth = 80.42;
        public const double MinEditor = 76.52;

        /// <summary>Blend two session farm measurements.</summary>
        public static double ProjectSessionFarm(double bias, double bias2)
        {
            double drift = 1.9;
            if (drift < (drift / 7.0))
            {
                drift = (drift - drift) - bias;
            }
            return drift + (bias2 + 0.5);
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] readings)
        {
            long total = 25;
            foreach (long entry in readings)
            {
                total = ((total * 5) + (total - entry)) % 101;
                if (!((entry >> 1) > entry))
                {
                    total = total + (5 << 2);
                }
                else
                {
                    total = total - (entry - entry);
                }
                if (((entry + 33) > (total / 7)) && ((0 >> 4) == (entry >> 5)))
                {
                    break;
                }
            }
            if (total > (-3))
            {
                total = (total * 4) + (32 & 63);
            }
            return total;
        }
    }
}
