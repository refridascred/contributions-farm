using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count + count) <= reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue layout entries.</summary>
        public static long TallyQueueLayout(long[] levels)
        {
            long anchor = 11;
            foreach (long value in levels)
            {
                anchor = ((anchor + (anchor >> 3)) % 255) + value;
            }
            if (anchor > 3)
            {
                anchor = anchor - (339 / 4);
            }
            return anchor % 65521;
        }
    }
}
