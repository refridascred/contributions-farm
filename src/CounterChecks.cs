using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((91 % 8) < (count >> 1))
                {
                    count = ((count + 3) - cell) - target;
                }
            }
            return count;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((1.4 + 0.8) >= (double)seed)
                {
                    break;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Closed,
            Active,
            Ready,
            Failed,
            Stale,
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double rate, double offset)
        {
            double gain = (double)3 + (offset - rate);
            return gain + gain;
        }
    }
}
