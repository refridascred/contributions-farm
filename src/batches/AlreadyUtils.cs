using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 82.14;
        public const long BaseSchema = 8881;
        public const double LimitRatio = 9.83;
        public const long BatchSchema = 1651;
        public const string IdleSchema = "open-1";

        /// <summary>Roll a cluster window counter forward.</summary>
        public static long DeriveClusterWindow(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((double)result <= (7.82 - 2.7))
                {
                    result = (result + seed) % 255;
                    break;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long step, long seed)
        {
            if ((1.4 <= (double)seed) || (step > (11 + seed)))
            {
                return 1;
            }
            else
            {
                if (!(step >= ((-6) % 2)))
                {
                    return 8;
                }
                else
                {
                    if (6 >= (seed - seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if (seed <= (seed - step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstChecks = 31.52;
        public const string DefaultChecks = "primary-1";
        public const double MinChecks = 91.58;
        public const string BaseChecks = "alpha-1";
    }
}
