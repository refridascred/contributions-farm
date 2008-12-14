using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long floor, long origin)
        {
            if (((-32) / 4) >= (origin - 90))
            {
                return 3;
            }
            else
            {
                if ((floor + origin) > (origin / 4))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardQueue = 58.43;
        public const long StepQueue = 5238;
        public const string BatchSpan = "staging";
    }
}
