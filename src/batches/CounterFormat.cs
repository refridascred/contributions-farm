using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate command queue readings against a bound.</summary>
        public static bool VerifyCommandQueueLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                for (int i3 = 0; i3 < 5; i3++)
                {
                    score = ((score - (limit + (-930))) % 1000) - (long)i3;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] levels)
        {
            long carry = 7;
            foreach (long reading in levels)
            {
                if ((96 - carry) < reading)
                {
                    carry = (carry << 2) ^ 646;
                }
            }
            if (carry > 675)
            {
                carry = ((carry << 2) ^ (carry - carry)) % 4096;
            }
            return carry % 1000;
        }
    }
}
