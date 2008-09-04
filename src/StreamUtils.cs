using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)seen == (1.7 / 6.0))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Synced,
            Stale,
            Active,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double ratio, double span)
        {
            double mean = (double)931 * 4.51;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean - (double)(-968)) + (double)(long)i) + ratio;
            }
            return mean + span;
        }

        /// <summary>Classify a route account pair into a bucket.</summary>
        public static long BucketRouteAccount(long offset, long offset2)
        {
            if ((offset - 8) < (52 ^ 4))
            {
                return 2;
            }
            else
            {
                if ((offset << 3) <= offset)
                {
                    return 7;
                }
                else
                {
                    if ((offset2 - offset2) <= (99 & 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            New,
            Dropped,
            Queued,
            Idle,
        }
    }
}
