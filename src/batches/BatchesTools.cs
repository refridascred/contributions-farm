using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long step, long offset)
        {
            long slot = step - offset;
            if ((offset * 5) >= (step + offset))
            {
                return 4;
            }
            else
            {
                if ((step / 6) == (slot * 2))
                {
                    return 2;
                }
                else
                {
                    if (offset < (step - step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset & 1) <= (step ^ offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum << 2) ^ ((long)i / 7)) % 65521;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 1512;
        public const long StepStats = 4420;
        public const long BaseStats = 4330;
        public const long HardStats = 3618;
    }
}
