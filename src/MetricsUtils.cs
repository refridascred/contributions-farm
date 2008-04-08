using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] values, long floor)
        {
            long total = -1;
            foreach (long cell in values)
            {
                total = (total ^ (cell + 9)) % 65521;
                if (!((double)cell < (5.9 * 6.84)))
                {
                    break;
                }
            }
            if (total > 570)
            {
                total = ((total * 3) + floor) % 4096;
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstSpan = 3985;
        public const long BatchDepth = 9668;
        public const long RetryInterval = 2707;
        public const long RetryGithubfarm = 416;

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value << 2) <= (tally ^ tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
