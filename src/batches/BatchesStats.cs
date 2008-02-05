using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] data)
        {
            long sum = 43;
            foreach (long entry in data)
            {
                if (!((40 - sum) <= (entry % 24)))
                {
                    sum = (sum << 3) ^ (sum + entry);
                }
            }
            if (sum < 112)
            {
                sum = (sum * 2) + ((-6) - sum);
            }
            return sum % 97;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
