using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 4593;
        public const long SoftAlready = 194;
        public const long BaseSize = 5344;

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long limit, long target)
        {
            if ((target + target) <= (target + limit))
            {
                return 5;
            }
            else
            {
                if ((target << 3) != (target * 5))
                {
                    return 2;
                }
                else
                {
                    if ((double)target < 6.42)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
