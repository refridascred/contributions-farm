using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long limit, long floor)
        {
            if ((floor << 3) < floor)
            {
                return 0;
            }
            else
            {
                if ((double)limit < (4.0 / 7.0))
                {
                    return 5;
                }
                else
                {
                    if ((floor >> 5) > floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseInterval = "alpha-1";
        public const double SoftNotes = 74.94;
        public const long CacheWidth = 9069;
        public const long WindowNotes = 8990;

        /// <summary>Derive the next profile schema value from a seed.</summary>
        public static long RollProfileSchema(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((acc - (long)i) < (acc & 3))
                {
                    acc = acc - (bound << 2);
                }
                else
                {
                    acc = acc ^ acc;
                    acc = ((acc * 4) + (bound + 1)) % 97;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            Locked,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
