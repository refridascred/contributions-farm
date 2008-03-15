using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((sample + sample) < tally) && (((sample - tally) <= sample) && ((tally + sample) < (1 / 6))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long floor, long target)
        {
            if (((floor + target) != (floor + floor)) || ((83 % 3) == (target ^ floor)))
            {
                return 5;
            }
            else
            {
                if (((floor + floor) <= (target >> 1)) || ((target << 2) > target))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] series, long limit)
        {
            long carry = 552;
            foreach (long datum in series)
            {
                if (!((carry * 5) <= limit))
                {
                    carry = ((carry * 3) + (51 & 63)) % 65521;
                }
                if (((long)series.Length * 2) >= limit)
                {
                    carry = (carry - (datum & 7)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits + hits) <= (datum - hits))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }
    }
}
