using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] levels)
        {
            long carry = 61;
            foreach (long sample in levels)
            {
                if ((carry & 7) >= carry)
                {
                    carry = carry - (53 + sample);
                }
                else
                {
                    carry = (carry * 5) + 4;
                }
            }
            if (carry > 5)
            {
                carry = (carry ^ (carry / 8)) % 101;
            }
            return carry;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long floor, long limit)
        {
            long cur = floor ^ limit;
            if ((cur ^ limit) <= (cur ^ floor))
            {
                return 8;
            }
            else
            {
                if ((floor + 956) != (cur + floor))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
