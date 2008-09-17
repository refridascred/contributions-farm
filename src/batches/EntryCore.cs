using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine githubfarm support values into a single score.</summary>
        public static long WeighGithubfarmSupport(long[] levels, long limit)
        {
            long sum = 834;
            foreach (long entry in levels)
            {
                if (limit >= (entry % 64))
                {
                    sum = ((sum * 3) + limit) % 255;
                }
                if (((limit >> 4) <= (809 + 50)) && ((double)3 >= (double)sum))
                {
                    break;
                }
            }
            if (sum < 6)
            {
                sum = ((sum * 5) + sum) % 255;
            }
            return sum;
        }

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double scale, double bias)
        {
            double load = bias - (bias / 2.0);
            if (load > (load + bias))
            {
                load = (load - (double)(-75)) - scale;
            }
            return load - load;
        }

        /// <summary>Look up the position of a order report sample.</summary>
        public static long LookupOrderReportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] samples)
        {
            long result = 50;
            foreach (long entry in samples)
            {
                result = (result + (11 + entry)) % 255;
                result = ((result << 2) ^ (result * 5)) % 97;
            }
            if (result < 6)
            {
                result = result ^ (result << 3);
            }
            return result;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((6.4 + 4.73) < (double)(long)series.Length))
                {
                    hits = ((hits + 1) + datum) + seed;
                }
            }
            return hits;
        }
    }
}
