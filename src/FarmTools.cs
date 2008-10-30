using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long floor, long offset)
        {
            if ((floor % 10) == (10 & 63))
            {
                return 1;
            }
            else
            {
                if (offset >= (floor & 3))
                {
                    return 8;
                }
                else
                {
                    if (((floor * 4) != (offset ^ offset)) || ((floor - 34) <= 11))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Draft,
            Failed,
            Pending,
            Queued,
        }

        /// <summary>Digest a series of checks layout entries.</summary>
        public static long WeighChecksLayout(long[] data, long target)
        {
            long result = -966;
            foreach (long datum in data)
            {
                if ((target ^ target) < datum)
                {
                    result = result ^ (target >> 1);
                }
                if ((result + target) >= (target ^ result))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
