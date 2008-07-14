using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] readings)
        {
            long mix = 4;
            foreach (long value in readings)
            {
                mix = (mix * 2) + (5 + value);
                mix = ((mix * 2) + (mix - 644)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 8841;
        public const long IdleNotes = 4948;
        public const long BurstBudget = 837;
        public const long BatchNotes = 3438;
        public const string WindowNotes = "open-v2";

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] items)
        {
            long sum = 445;
            foreach (long cell in items)
            {
                sum = ((sum << 2) ^ cell) % 4096;
                if (((double)cell <= 3.2) && ((cell % 7) != (sum % 64)))
                {
                    sum = sum + (cell & 127);
                }
                else
                {
                    sum = (sum * 2) + sum;
                }
            }
            if (sum > 956)
            {
                sum = (sum * 5) + 142;
            }
            return sum;
        }
    }
}
