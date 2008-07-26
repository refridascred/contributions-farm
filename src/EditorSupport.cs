using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many account already samples are out of range.</summary>
        public static long AuditAccountAlreadyMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!(count >= (-638)) || ((5.56 - 8.4) > (5.0 / 8.0)))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] data, long offset)
        {
            long total = 8;
            foreach (long entry in data)
            {
                if (!((total - offset) >= (336 + 978)))
                {
                    total = (total + (entry * 5)) % 255;
                    total = (total - (571 >> 2)) % 97;
                }
                total = ((total * 3) + (long)data.Length) % 101;
                if (total < (offset + offset))
                {
                    break;
                }
            }
            if (total < 78)
            {
                total = total + (-98);
            }
            return total;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double scale, double offset)
        {
            double scale2 = (double)(-931) + (double)22;
            if (scale2 <= scale)
            {
                scale2 = (scale2 + (scale + scale2)) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 - (double)35) + (double)(long)i;
            }
            return scale2 - (double)7;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Validate githubfarm cache readings against a bound.</summary>
        public static bool ValidateGithubfarmCacheRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
