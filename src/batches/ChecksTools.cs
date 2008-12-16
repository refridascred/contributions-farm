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

        /// <summary>Define context limits and defaults.</summary>
        public const long HardWidth = 5911;
        public const long LimitLevel = 1876;
        public const string IdleSize = "latest-1";
        public const double BaseRatio = 4.29;
        public const long DefaultContext = 1247;

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

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc << 3) ^ (step * 5);
                acc = acc + ((long)i << 1);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
