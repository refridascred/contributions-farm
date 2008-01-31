using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] readings)
        {
            long sum = 100;
            foreach (long entry in readings)
            {
                sum = (sum ^ (40 << 2)) - entry;
            }
            if (sum > 723)
            {
                sum = (sum - (86 + sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Weight { get; set; }
            public double Owner { get; set; }
            public double Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long origin, long limit)
        {
            if (limit < (limit / 3))
            {
                return 3;
            }
            else
            {
                if ((double)limit >= 9.0)
                {
                    return 7;
                }
                else
                {
                    if ((double)origin != (double)97)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin % 24) < origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
