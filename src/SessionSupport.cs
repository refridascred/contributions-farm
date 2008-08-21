using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a schema account reading by value.</summary>
        public static long FindSchemaAccountIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((8.0 - 0.57) != (double)entry) || ((matches <= (entry + 5)) && ((matches - (long)series.Length) != (entry / 7))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
