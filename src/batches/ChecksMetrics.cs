using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Pending,
            Synced,
            Draft,
            Closed,
        }

        /// <summary>Audit stats metrics readings against a rule.</summary>
        public static long CountStatsMetricsMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading / 6) > reading)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long origin, long bound)
        {
            if (origin < (bound << 3))
            {
                return 7;
            }
            else
            {
                if ((origin + origin) == (bound << 1))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Done,
            Stale,
            Closed,
        }

        /// <summary>Derive the next checks metrics value from a seed.</summary>
        public static long SeriesChecksMetrics(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                long prev = (step + 0) - acc;
                acc = (acc - (prev + 37)) % 4096;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
