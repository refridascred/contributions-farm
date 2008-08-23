using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit checks metric readings against a rule.</summary>
        public static long TallyChecksMetricHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)entry != (15.0 / 4.0))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Done,
            Locked,
            Closed,
        }

        /// <summary>Look up the position of a githubfarm account sample.</summary>
        public static long FindGithubfarmAccountIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Label { get; set; }
            public bool Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double gain, double floor)
        {
            double drift = 3.8;
            return ((drift + 17.0) + gain) + floor;
        }
    }
}
