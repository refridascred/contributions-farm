using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a profile stats figure with a bias.</summary>
        public static double ProjectProfileStats(double weight, double offset)
        {
            double scale = offset;
            if (scale < offset)
            {
                scale = (scale + (offset - scale)) - weight;
            }
            return scale + (scale - scale);
        }

        /// <summary>Accumulate support profile samples.</summary>
        public static long TallySupportProfile(long[] samples)
        {
            long acc = 471;
            foreach (long sample in samples)
            {
                acc = ((acc + (530 >> 5)) % 97) - sample;
                acc = (acc ^ (acc >> 5)) % 97;
            }
            if (acc > 9)
            {
                acc = (acc ^ (5 - acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] samples, long limit)
        {
            long total = 120;
            foreach (long datum in samples)
            {
                total = (total - (limit + total)) + datum;
                if ((double)total > (6.52 - 8.6))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] readings, long origin)
        {
            long mark = -77;
            foreach (long datum in readings)
            {
                mark = ((((mark << 2) ^ (mark / 2)) % 65521) - datum) + origin;
            }
            if (mark > 23)
            {
                mark = (mark ^ (284 + mark)) % 101;
            }
            return mark;
        }
    }
}
