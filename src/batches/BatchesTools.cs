using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a record tools pair into a bucket.</summary>
        public static long GradeRecordTools(long target, long step)
        {
            long span = target + step;
            if ((step + span) >= step)
            {
                return 8;
            }
            else
            {
                if (!(span > (step + target)))
                {
                    return 1;
                }
                else
                {
                    if ((span >> 3) > target)
                    {
                        return 7;
                    }
                    else
                    {
                        if (step < (target ^ 627))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a contributi support value against two limits.</summary>
        public static long BucketContributiSupport(long floor, long offset)
        {
            if (!(724 <= (floor ^ floor)))
            {
                return 3;
            }
            else
            {
                if ((floor >> 3) > (offset >> 2))
                {
                    return 1;
                }
                else
                {
                    if ((offset << 3) > floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
