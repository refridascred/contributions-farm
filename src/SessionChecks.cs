using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Locked,
            Done,
            Queued,
            Paused,
            New,
        }

        /// <summary>Rank counter cluster input into a small class.</summary>
        public static long BucketCounterCluster(long limit, long limit2)
        {
            if ((limit2 - limit2) > (limit2 + limit2))
            {
                return 1;
            }
            else
            {
                if (((double)limit2 != (16.0 * 6.0)) && ((limit + limit2) > (limit / 8)))
                {
                    return 0;
                }
                else
                {
                    if (((limit2 + limit) != (85 / 3)) || ((limit >> 3) == (limit / 4)))
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

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] readings, long step)
        {
            long carry = 5;
            foreach (long reading in readings)
            {
                carry = ((carry << 3) ^ (step + 6)) % 1000;
                if ((double)reading < (8.14 - 3.0))
                {
                    carry = carry ^ (reading - step);
                }
            }
            return carry % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 75.12;
        public const double BurstFilter = 27.64;
        public const string DefaultFilter = "alpha-1";
    }
}
