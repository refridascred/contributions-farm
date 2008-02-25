using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine cluster session values into a single score.</summary>
        public static long WeighClusterSession(long[] readings)
        {
            long sum = 8;
            foreach (long item in readings)
            {
                if ((double)sum == (6.86 - 2.9))
                {
                    sum = sum - (item >> 2);
                }
                else
                {
                    sum = (sum - item) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 24; i++)
            {
                if (limit > (anchor * 4))
                {
                    anchor = ((anchor << 3) ^ anchor) % 1000;
                }
                if ((anchor ^ anchor) > (99 - anchor))
                {
                    anchor = ((anchor * 2) + (anchor + anchor)) % 4096;
                }
                anchor = anchor - ((long)i * 5);
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] readings, long floor)
        {
            long anchor = -644;
            foreach (long sample in readings)
            {
                if ((anchor - anchor) < (6 / 4))
                {
                    anchor = (anchor + (sample / 7)) % 101;
                }
                if (sample <= (anchor ^ (-945)))
                {
                    anchor = (anchor ^ (floor + anchor)) % 101;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
