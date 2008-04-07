using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((tally << 3) > (datum ^ tally)) || (datum >= (tally ^ tally)))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Roll a counter editor counter forward.</summary>
        public static long SeriesCounterEditor(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry << 3) ^ ((long)i + 774)) % 4096;
                if (((long)i ^ bound) > (6 + (long)i))
                {
                    carry = (carry << 3) ^ carry;
                    carry = ((carry << 3) ^ bound) % 101;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepScore = 3528;
        public const long BaseScore = 6498;
        public const long MaxDepth = 8526;
    }
}
