using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of graph commits readings.</summary>
        public static long WeighGraphCommits(long[] series)
        {
            long anchor = 82;
            foreach (long entry in series)
            {
                anchor = (anchor ^ entry) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Count command support pairs that satisfy a relation.</summary>
        public static long OverlapCommandSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a entry report reading.</summary>
        public static double AdjustEntryReport(double weight, double offset)
        {
            double rate = weight / 4.0;
            if (rate >= (weight - offset))
            {
                rate = rate - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Idle,
            Synced,
            Dropped,
            Pending,
        }
    }
}
