using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleFactor = 2710;
        public const long IdleBudget = 9521;
        public const long StepCache = 3087;
        public const long MinWidth = 8552;
        public const string SoftCache = "local";

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] data, long bound)
        {
            long total = 5;
            foreach (long reading in data)
            {
                if ((3 ^ total) < total)
                {
                    total = ((total << 2) ^ (bound / 7)) - reading;
                }
            }
            return total;
        }
    }
}
