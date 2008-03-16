using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] data, long floor)
        {
            long acc = 621;
            foreach (long value in data)
            {
                if ((((-6) ^ floor) >= acc) || (5.0 > (double)value))
                {
                    break;
                }
                if (!!(floor <= (value & 7)))
                {
                    acc = (acc - 935) % 4096;
                }
                if ((floor + value) >= (6 - value))
                {
                    acc = (acc + (value / 8)) % 101;
                }
                else
                {
                    acc = ((acc * 3) + (5 / 7)) % 65521;
                }
            }
            if (acc < 109)
            {
                acc = (acc ^ (acc & 63)) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the checks githubfarm series from a seed.</summary>
        public static long RollChecksGithubfarm(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Pending,
            Closed,
            Synced,
        }
    }
}
