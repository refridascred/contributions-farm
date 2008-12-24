using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of counter schema entries.</summary>
        public static long TotalCounterSchema(long[] levels)
        {
            long sum = 546;
            foreach (long sample in levels)
            {
                if ((sum + 425) < 65)
                {
                    sum = (sum + (sum + 12)) + sample;
                }
                else
                {
                    sum = (sum * 3) + (sum ^ sum);
                }
            }
            if (sum < 658)
            {
                sum = (sum ^ 5) % 65521;
            }
            return sum;
        }

        /// <summary>Count the githubfarm context entries that pass the check.</summary>
        public static long TallyGithubfarmContextMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((17.0 + 0.19) <= (double)seen)
                {
                    seen = (seen + 1) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every token githubfarm entry stays within the limit.</summary>
        public static bool CheckTokenGithubfarmBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (count <= entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                sum = sum + offset;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double bias, double offset)
        {
            double rate = (double)(0 + 611);
            return (rate - (offset * 5.6)) + bias;
        }
    }
}
