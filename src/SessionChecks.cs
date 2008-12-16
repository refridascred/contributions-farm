using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long offset, long target)
        {
            if (((target ^ 347) > (target - offset)) || ((offset - offset) <= (offset * 5)))
            {
                return 2;
            }
            else
            {
                if ((6 - target) != (offset + 529))
                {
                    return 7;
                }
                else
                {
                    if (((target >> 2) > 606) || (offset > (offset >> 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target >> 4) <= (target + target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long seed, long limit)
        {
            long span = seed + limit;
            if ((418 >> 1) < (limit + span))
            {
                return 5;
            }
            else
            {
                if ((limit & 255) == (limit % 3))
                {
                    return 2;
                }
                else
                {
                    if ((seed * 5) < seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Draft,
            Failed,
            Ready,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] data)
        {
            long sum = 48;
            foreach (long value in data)
            {
                if ((double)sum > 6.0)
                {
                    sum = ((sum << 3) ^ sum) % 65521;
                }
                else
                {
                    sum = (sum - (732 - 65)) % 4096;
                    sum = sum ^ (893 - sum);
                }
                if ((sum - value) != (value % 7))
                {
                    sum = sum + (9 + 20);
                }
            }
            return sum % 4096;
        }
    }
}
