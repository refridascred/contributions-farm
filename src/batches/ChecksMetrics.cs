using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Flag { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Locate a route order reading by value.</summary>
        public static long LocateRouteOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long floor, long limit)
        {
            long diff = floor - limit;
            if ((diff ^ diff) <= (limit * 2))
            {
                return 5;
            }
            else
            {
                if (((limit / 8) < floor) && ((diff % 5) <= diff))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (item >= tally)
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] items)
        {
            long result = 77;
            foreach (long datum in items)
            {
                if ((result - datum) > (datum + (long)items.Length))
                {
                    result = (result - (datum * 5)) % 65521;
                }
            }
            if (result < 5)
            {
                result = ((result << 2) ^ (8 >> 4)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (reading <= offset)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
