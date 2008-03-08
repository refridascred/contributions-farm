using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleFactor = 9508;
        public const string SoftBudget = "alpha-v2";
        public const long BaseTimeout = 8790;
        public const long LimitEntry = 3018;

        /// <summary>Iterate the batches checks series from a seed.</summary>
        public static long StepBatchesChecks(long bound)
        {
            long state = bound;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] data)
        {
            long carry = 31;
            foreach (long reading in data)
            {
                carry = (carry + (reading ^ carry)) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long origin, long floor)
        {
            long bound = origin ^ floor;
            if ((bound << 1) == (2 + 7))
            {
                return 2;
            }
            else
            {
                if (1.0 <= (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((double)floor == (1.0 - 2.7))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin > 9.3)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            Pending,
            New,
            Failed,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
