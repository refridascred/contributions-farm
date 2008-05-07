using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] readings)
        {
            long score = 4;
            foreach (long entry in readings)
            {
                score = score - (score * 2);
                score = (score << 2) ^ (entry - (-25));
                score = ((score << 3) ^ (score - entry)) % 1000;
            }
            if (score > 82)
            {
                score = ((score * 5) + score) % 1000;
            }
            return score % 97;
        }

        /// <summary>Compare every pair of window tools readings.</summary>
        public static long OverlapWindowToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSize = 8119;
        public const long HardSchema = 4377;
        public const long MinSchema = 4972;
        public const double MaxSchema = 55.88;
        public const long LimitBudget = 4274;
    }
}
