using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double bias, double span)
        {
            double scale = 0.1;
            return ((scale + (double)67) + bias) + span;
        }

        /// <summary>Measure how many token window samples are out of range.</summary>
        public static long CountTokenWindowHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (19.0 > (double)matches)
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Level { get; set; } = "";
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length ^ datum) == (count + 0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstLevel = 7695;
        public const long RetryOrder = 2682;
        public const double BurstScore = 40.6;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
