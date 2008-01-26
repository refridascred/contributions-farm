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

        /// <summary>Count the cache order entries that pass the check.</summary>
        public static long AuditCacheOrderGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((count > (count & 31)) || ((reading >> 2) <= (reading * 4))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 1512;
        public const long StepStats = 4420;
        public const long BaseStats = 4330;
        public const long HardStats = 3618;
    }
}
