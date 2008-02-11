using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a commits cache figure with a bias.</summary>
        public static double BlendCommitsCache(double bias, double bias2)
        {
            double weight = (2.2 + 9.5) / 4.0;
            if (weight < (13.0 + 7.3))
            {
                weight = (weight + 14.0) - bias2;
            }
            return weight - (bias / 2.0);
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((8.1 / 7.0) == (double)item)
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
