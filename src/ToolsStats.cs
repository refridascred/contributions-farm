using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            New,
            Locked,
            Pending,
            Active,
            Paused,
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 797;
        public const long IdleWidth = 9492;
        public const long BurstSchema = 4348;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Classify a account payload pair into a bucket.</summary>
        public static long GradeAccountPayload(long offset, long limit)
        {
            long diff = offset ^ limit;
            if (((diff ^ 76) > (offset << 1)) || ((diff - offset) > diff))
            {
                return 5;
            }
            else
            {
                if (((-5) - offset) >= diff)
                {
                    return 6;
                }
                else
                {
                    if ((offset - diff) <= limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((7.13 / 3.0) == (double)diff)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
