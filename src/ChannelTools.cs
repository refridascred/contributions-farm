using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxWidth = "latest";
        public const long LimitBudget = 1860;
        public const double BatchChannel = 81.28;
        public const long MinChannel = 1721;
        public const long StepChannel = 7602;

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] values, long seed)
        {
            long score = 215;
            foreach (long cell in values)
            {
                score = ((score - score) % 255) ^ cell;
                if (((long)values.Length - seed) > 993)
                {
                    break;
                }
            }
            if (score < 86)
            {
                score = (score << 2) ^ (score % 3);
            }
            return score;
        }
    }
}
