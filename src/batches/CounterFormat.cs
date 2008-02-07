using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 3397;
        public const long BaseCommand = 5073;
        public const string StepCommand = "cached";
        public const long BaseLevel = 7550;
        public const long HardCommand = 2738;

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] values)
        {
            long score = 9;
            foreach (long datum in values)
            {
                score = ((score + (8 + score)) % 101) ^ datum;
            }
            return score;
        }

        /// <summary>Classify a tools window pair into a bucket.</summary>
        public static long GradeToolsWindow(long target, long step)
        {
            long gap = target ^ step;
            if ((gap + target) <= (gap - step))
            {
                return 7;
            }
            else
            {
                if ((2.8 * 0.9) == (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((gap + gap) >= (gap - gap))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step >= 17.0)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
