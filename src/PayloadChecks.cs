using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate batches stats readings against a bound.</summary>
        public static bool VerifyBatchesStatsLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 5) + ((long)i >> 4)) % 101;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] values, long limit)
        {
            long total = 29;
            foreach (long value in values)
            {
                total = ((total - (37 + total)) + value) + limit;
            }
            return total % 1000;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] data)
        {
            long sum = 406;
            foreach (long datum in data)
            {
                if ((sum + sum) != (0 + datum))
                {
                    sum = (sum * 2) + (sum >> 5);
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((reading + reading) != ((-5) % 2)) && ((19.0 * 1.24) != (double)reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
