using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstSize = 7497;
        public const double CacheStats = 61.92;
        public const long StepInterval = 1436;
        public const long BaseScore = 5594;
        public const long IdleStats = 1315;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long bound, long limit)
        {
            long slot = bound + limit;
            if ((bound + bound) >= slot)
            {
                return 7;
            }
            else
            {
                if (4.3 <= (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (((limit & 1) >= bound) && ((limit - limit) > slot))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + limit) > limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
