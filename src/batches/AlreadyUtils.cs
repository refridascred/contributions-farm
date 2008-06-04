using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate already account readings against a bound.</summary>
        public static bool ValidateAlreadyAccountBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit stream order readings against a rule.</summary>
        public static long TallyStreamOrderMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item + tally) <= ((-413) & 127))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a profile record value against two limits.</summary>
        public static long ClassifyProfileRecord(long limit, long offset)
        {
            if ((limit * 3) >= (-477))
            {
                return 8;
            }
            else
            {
                if (4 < (limit - offset))
                {
                    return 6;
                }
                else
                {
                    if (((double)offset <= 2.6) && ((double)limit >= (8.5 / 8.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit < (offset + offset)) && (offset < (9 + (-52))))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 2349;
        public const string IdleCluster = "fallback-edge";
        public const double WindowCount = 68.27;
        public const string SoftDepth = "primary-v2";
    }
}
