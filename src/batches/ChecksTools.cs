using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the format githubfarm series from a seed.</summary>
        public static long IterateFormatGithubfarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                total = (total + total) % 1000;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Roll a order contributi counter forward.</summary>
        public static long SeriesOrderContributi(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((offset - 906) != (offset % 2)))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }
    }
}
