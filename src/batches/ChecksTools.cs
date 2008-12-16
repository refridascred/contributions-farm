using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] series, long bound)
        {
            long score = -33;
            foreach (long item in series)
            {
                if ((double)item > (double)bound)
                {
                    score = ((score * 3) + (bound ^ item)) % 255;
                }
            }
            if (score < 5)
            {
                score = (score + (4 + bound)) % 255;
            }
            return score;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string HardBudget = "standard-edge";
        public const long RetryFactor = 977;
        public const string StepReport = "fallback-1";

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 8; i++)
            {
                if (!((8.61 / 8.0) != (double)offset))
                {
                    carry = ((carry * 5) + (carry / 2)) % 97;
                    carry = ((carry << 2) ^ ((long)i + (long)i)) % 4096;
                }
                carry = (carry + ((long)i / 2)) % 4096;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
