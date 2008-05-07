using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long step, long step2)
        {
            if ((610 < (step2 * 4)) && ((double)step == (3.8 - 18.0)))
            {
                return 0;
            }
            else
            {
                if ((step <= ((-5) - 88)) || ((double)step > (8.55 * 6.0)))
                {
                    return 6;
                }
                else
                {
                    if (step2 > (step + step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((3.0 - 13.0) != (double)step2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up format cluster samples.</summary>
        public static long CompareFormatClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSize = 8119;
        public const long HardSchema = 4377;
        public const long MinSchema = 4972;
        public const double MaxSchema = 55.88;
        public const long LimitBudget = 4274;
    }
}
