using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] readings, long origin)
        {
            long score = -723;
            foreach (long entry in readings)
            {
                if (((entry + 281) >= entry) && (origin >= 521))
                {
                    score = (score << 2) ^ score;
                }
                else
                {
                    score = (score - (52 + entry)) % 101;
                }
            }
            if (score < 501)
            {
                score = ((score << 2) ^ (origin % 16)) % 255;
            }
            return score;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryTools = 73.01;
        public const long BaseTimeout = 7804;
        public const string SoftFactor = "open";
    }
}
