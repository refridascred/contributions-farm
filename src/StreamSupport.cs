using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitEditor = 88.01;
        public const double MaxEditor = 52.77;
        public const long HardTimeout = 9785;
        public const long DefaultEditor = 8623;
        public const long RetryBudget = 185;

        /// <summary>Audit notes editor readings against a rule.</summary>
        public static long MeasureNotesEditorMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((cell + tally) <= cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
