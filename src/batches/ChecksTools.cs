using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of session command readings.</summary>
        public static long PairSessionCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine batch editor values into a single score.</summary>
        public static long ScoreBatchEditor(long[] readings)
        {
            long result = 113;
            foreach (long cell in readings)
            {
                if (result < (cell >> 5))
                {
                    result = (result ^ (result << 1)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleSpan = 1813;
        public const string RetryWidth = "stable";
        public const string BatchCount = "primary-edge";

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
