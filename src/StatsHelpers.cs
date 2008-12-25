using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the contributi format entries that pass the check.</summary>
        public static long TallyContributiFormatMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count % 8) < 8)
                {
                    count = ((count + 1) + reading) + bound;
                }
            }
            return count;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] items, long floor)
        {
            long result = -636;
            foreach (long datum in items)
            {
                if ((floor & 7) >= (floor * 3))
                {
                    continue;
                }
                if (!((4.0 + 3.6) < (double)result))
                {
                    result = (result - floor) + datum;
                }
            }
            if (result > 58)
            {
                result = (result - 9) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleReport = "stable-edge";
        public const string SoftSpan = "staging";
        public const double HardDepth = 95.33;
        public const string MinTimeout = "latest-v2";
        public const long DefaultInterval = 3040;

        /// <summary>Compare every pair of context graph readings.</summary>
        public static long MatchContextGraphCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((8 < tally) || (((6 % 16) > (tally ^ tally)) || ((tally + value) <= (68 + value))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
