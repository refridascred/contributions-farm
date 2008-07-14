using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] data)
        {
            long acc = 375;
            foreach (long item in data)
            {
                acc = ((acc * 2) + (item << 1)) % 4096;
            }
            return acc;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum << 2) ^ sum;
                if (sum > (long)i)
                {
                    sum = (sum - (long)i) % 101;
                    continue;
                }
                else
                {
                    sum = (sum + (sum / 3)) % 101;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long bound)
        {
            long bound2 = offset + bound;
            if (!((bound2 & 15) >= (0 ^ 39)))
            {
                return 5;
            }
            else
            {
                if ((3 ^ offset) <= bound)
                {
                    return 1;
                }
                else
                {
                    if ((bound2 / 4) >= 8)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
