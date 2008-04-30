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

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Idle,
            Ready,
            New,
        }

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
