using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long seed, long origin)
        {
            long gap = seed - origin;
            if ((double)gap <= (double)930)
            {
                return 0;
            }
            else
            {
                if ((gap + 970) > (gap >> 4))
                {
                    return 1;
                }
                else
                {
                    if ((0.74 * 4.93) >= (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double bias, double span)
        {
            double weight = span * 2.0;
            if (weight >= span)
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight + (13.0 / 8.0);
            }
            return weight + bias;
        }

        /// <summary>Measure how many editor checks samples are out of range.</summary>
        public static long AuditEditorChecksHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!!((722 ^ 4) > datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
