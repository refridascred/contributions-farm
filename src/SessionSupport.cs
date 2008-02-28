using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long floor, long target)
        {
            long offset = floor ^ target;
            if (floor <= (offset >> 4))
            {
                return 2;
            }
            else
            {
                if (!((target >> 4) >= (88 % 3)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Failed,
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double ratio, double offset)
        {
            double gain = offset;
            if (gain > ratio)
            {
                gain = gain + (ratio * 9.3);
            }
            else
            {
                gain = gain - (double)746;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (8.92 + offset)) - (double)(long)i;
            }
            return gain + (double)20;
        }
    }
}
