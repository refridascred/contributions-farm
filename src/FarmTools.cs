using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseCommits = "cached";
        public const long HardCommits = 7928;
        public const string HardScore = "strict-1";
        public const long SoftCommits = 2036;
        public const long IdleRatio = 63;

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the stream metrics entries that pass the check.</summary>
        public static long TallyStreamMetricsHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)bound < (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
