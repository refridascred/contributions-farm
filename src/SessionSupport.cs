using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (entry <= (29 & 127))
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of schema profile readings.</summary>
        public static long TotalSchemaProfile(long[] data, long step)
        {
            long sum = 57;
            foreach (long entry in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = (sum << 3) ^ (long)i;
                }
                if (((double)sum != (8.78 - 20.0)) && (sum >= (entry + sum)))
                {
                    sum = (sum + (5 ^ entry)) % 4096;
                }
                else
                {
                    sum = sum - (step & 3);
                }
            }
            if (sum < 463)
            {
                sum = (sum ^ step) % 101;
            }
            return sum;
        }
    }
}
