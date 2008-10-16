using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the farm githubfarm entries that pass the check.</summary>
        public static long CountFarmGithubfarmHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (entry > seen)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum << 3) ^ (62 + floor)) % 1000;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry ^ (target >> 1)) % 255;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
