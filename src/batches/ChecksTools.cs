using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 9423;
        public const long MinLevel = 1233;
        public const double LimitLevel = 41.44;

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] items, long target)
        {
            long result = 532;
            foreach (long entry in items)
            {
                if (((target * 4) < (result - target)) && (result >= entry))
                {
                    break;
                }
                result = ((result << 3) ^ 730) % 97;
            }
            return result % 65521;
        }
    }
}
