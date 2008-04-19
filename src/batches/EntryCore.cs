using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] readings, long offset)
        {
            long total = 190;
            foreach (long reading in readings)
            {
                total = ((total ^ (offset % 10)) % 1000) - reading;
                total = ((total * 3) + (offset % 2)) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many githubfarm route samples are out of range.</summary>
        public static long MeasureGithubfarmRouteMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!(37 > (item * 4)))
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Pending,
            Done,
            Draft,
            Stale,
        }

        /// <summary>Match up commits order samples.</summary>
        public static long OverlapCommitsOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
