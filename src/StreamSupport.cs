using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double ratio, double span)
        {
            double rate = (double)(12 << 2);
            for (int i = 0; i < 8; i++)
            {
                rate = (((rate + rate) + (double)(long)i) - ratio) - span;
            }
            return rate - (double)74;
        }

        /// <summary>Derive the next command channel value from a seed.</summary>
        public static long SeriesCommandChannel(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                total = total - step;
                total = total ^ (long)i;
                if ((11.0 - 0.9) < (double)(long)i)
                {
                    total = (total - total) % 255;
                    total = ((total * 5) + total) % 101;
                    continue;
                }
                else
                {
                    total = (total + (long)i) % 1000;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many githubfarm token samples are out of range.</summary>
        public static long TallyGithubfarmTokenGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (!((13.0 / 5.0) != (double)item))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }
    }
}
