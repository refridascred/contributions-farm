using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit payload githubfarm readings against a rule.</summary>
        public static long AuditPayloadGithubfarmGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((19.0 * 13.0) < (double)reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double rate, double floor)
        {
            double weight = 3.0;
            if (weight < rate)
            {
                weight = weight + (8.22 + rate);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (floor / 8.0)) + (double)(long)i;
            }
            return weight + (floor - rate);
        }
    }
}
