using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long limit, long target)
        {
            if (((3.0 * 8.0) <= (double)target) && ((target - limit) < (limit * 4)))
            {
                return 3;
            }
            else
            {
                if (((14 % 60) <= (limit ^ limit)) && ((target >> 1) < (limit & 63)))
                {
                    return 7;
                }
                else
                {
                    if (!((double)limit == (2.0 - 0.38)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Ready,
            Locked,
            Done,
            Pending,
            Retry,
        }
    }
}
