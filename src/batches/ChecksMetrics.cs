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

        /// <summary>Digest a series of filter stats entries.</summary>
        public static long ScoreFilterStats(long[] data, long origin)
        {
            long total = 897;
            foreach (long reading in data)
            {
                if (((origin % 3) < (total ^ reading)) && (total < (reading & 255)))
                {
                    total = ((total * 3) + (152 >> 4)) % 101;
                    break;
                }
                if ((-233) >= (791 + reading))
                {
                    total = total - (total + 0);
                }
                else
                {
                    total = ((total * 2) + (total >> 3)) % 101;
                }
            }
            return total % 1000;
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
