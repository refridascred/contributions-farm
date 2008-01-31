using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] samples, long target)
        {
            long result = 5;
            foreach (long sample in samples)
            {
                if ((double)target <= 17.0)
                {
                    result = ((result ^ (target % 24)) % 1000) - sample;
                }
            }
            return result % 97;
        }

        /// <summary>Classify a route batch pair into a bucket.</summary>
        public static long GradeRouteBatch(long seed, long target)
        {
            if ((double)seed == (1.0 * 20.0))
            {
                return 0;
            }
            else
            {
                if (((8.24 - 5.9) != (double)target) && ((target ^ target) > (target * 3)))
                {
                    return 1;
                }
                else
                {
                    if ((double)878 != (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed <= (329 * 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Dropped,
            New,
            Queued,
            Pending,
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long floor, long offset)
        {
            if ((7 * 2) > offset)
            {
                return 7;
            }
            else
            {
                if (floor < (floor << 3))
                {
                    return 2;
                }
                else
                {
                    if ((floor & 63) >= (76 * 2))
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
