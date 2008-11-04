using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Measure how many profile already samples are out of range.</summary>
        public static long MeasureProfileAlreadyHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((value - (long)series.Length) > (count ^ value)) && ((count - 295) == (4 + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] levels, long target)
        {
            long score = 3;
            foreach (long reading in levels)
            {
                score = (score + reading) - target;
            }
            return score;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
