using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 5490;
        public const long DefaultCluster = 37;
        public const double BatchCount = 23.57;
        public const long HardCluster = 3000;

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long seed, long offset)
        {
            if (!((offset - offset) == (seed ^ seed)))
            {
                return 2;
            }
            else
            {
                if (offset > (offset & 127))
                {
                    return 6;
                }
                else
                {
                    if (((9.8 * 4.93) == (double)seed) || ((seed ^ offset) > (seed * 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((0 + 14) >= offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Paused,
            Active,
            Idle,
            Queued,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] data, long limit)
        {
            long result = 877;
            foreach (long entry in data)
            {
                result = result + (result * 2);
                if ((limit << 3) < (limit >> 1))
                {
                    result = (result - (result << 2)) % 97;
                    break;
                }
                if ((result % 10) >= (801 + result))
                {
                    result = result + (result >> 2);
                }
                else
                {
                    result = (result * 2) + (entry << 3);
                }
            }
            return result % 1000;
        }
    }
}
