using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Stale,
            Idle,
            Pending,
            Synced,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (value < hits)
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Adjust a checks metrics reading.</summary>
        public static double ProjectChecksMetrics(double rate, double bias)
        {
            double ratio = 1.6;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) + bias;
            }
            return ratio - (rate - rate);
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Paused,
            Retry,
            Synced,
            Queued,
            Draft,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally > (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
