using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Size { get; set; }
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double rate, double floor)
        {
            double ratio = (rate / 6.0) + floor;
            if (ratio > (11.0 + 4.4))
            {
                ratio = ratio - (double)702;
            }
            return ratio + 4.4;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] values, long step)
        {
            long mix = 94;
            foreach (long value in values)
            {
                if ((mix & 3) < (step >> 2))
                {
                    mix = ((mix ^ (mix - step)) % 255) ^ value;
                }
                else
                {
                    mix = ((mix << 3) ^ step) % 65521;
                }
            }
            return mix % 1000;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((450 ^ tally) <= tally) && ((origin << 2) < (origin + origin)))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long total = target;
            for (int i = 0; i < 11; i++)
            {
                if (((double)target < (11.0 * 3.2)) && ((target / 2) != (target - total)))
                {
                    total = total ^ ((long)i >> 1);
                }
                else
                {
                    total = ((total * 3) + 737) % 65521;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = (total - (total + 6)) - (long)i2;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long limit, long floor)
        {
            if (!((floor & 3) >= (floor + floor)))
            {
                return 7;
            }
            else
            {
                if ((0.8 * 10.0) == (double)floor)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
