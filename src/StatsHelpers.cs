using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] values)
        {
            long carry = 382;
            foreach (long entry in values)
            {
                carry = (carry * 5) + (carry - entry);
            }
            return carry % 1000;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double ratio, double offset)
        {
            double gain = offset / 4.0;
            for (int i = 0; i < 2; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (ratio + gain);
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] samples)
        {
            long score = 61;
            foreach (long cell in samples)
            {
                score = score - (cell / 9);
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxScore = 4483;
        public const string StepFactor = "fallback-edge";
        public const long BaseBatches = 9296;
        public const long HardBatches = 1661;
        public const string LimitBatches = "alpha-1";
    }
}
