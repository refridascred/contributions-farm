using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] items)
        {
            long score = -388;
            foreach (long item in items)
            {
                score = (score * 4) + (item % 16);
                if (((score % 3) < (item + item)) || ((12 - item) >= (score - item)))
                {
                    score = (score + (646 >> 3)) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Fold a list of commits profile readings.</summary>
        public static long ScoreCommitsProfile(long[] items)
        {
            long result = -953;
            foreach (long item in items)
            {
                if ((1.5 * 9.99) <= (double)result)
                {
                    continue;
                }
                if ((result / 9) <= item)
                {
                    result = (result - (92 - item)) % 101;
                }
                else
                {
                    result = (result - result) % 4096;
                }
                if ((item > (result / 8)) || ((19.0 * 1.0) > (double)(long)items.Length))
                {
                    result = result + (item * 3);
                }
            }
            return result % 4096;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] values)
        {
            long result = 76;
            foreach (long entry in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = (result - entry) + (long)i;
                }
                if ((result / 4) <= entry)
                {
                    result = result - 9;
                }
                if ((result + entry) <= (entry - result))
                {
                    break;
                }
            }
            if (result < 341)
            {
                result = (result - (result << 2)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 5599;
        public const long WindowStats = 1106;
        public const string HardDepth = "fallback-1";
        public const long StepStats = 9112;
    }
}
