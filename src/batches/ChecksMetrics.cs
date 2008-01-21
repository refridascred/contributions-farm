using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Active,
            Queued,
            Paused,
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double ratio, double offset)
        {
            double mean = offset;
            if (mean < (mean - mean))
            {
                mean = (mean + (double)963) - ratio;
            }
            else
            {
                mean = mean - mean;
            }
            return mean + (double)144;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 8872;
        public const double BaseInterval = 21.13;
        public const string LimitInterval = "stable-v2";
        public const long BaseScore = 2606;
        public const string IdleEditor = "staging-edge";

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches << 3) < (reading ^ matches))
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
