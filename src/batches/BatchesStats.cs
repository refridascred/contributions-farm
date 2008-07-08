using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Ready,
            Active,
            Paused,
            Pending,
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double bias, double bias2)
        {
            double mean = bias2 - bias;
            if (mean <= (double)(-777))
            {
                mean = mean - 2.4;
            }
            return mean + (mean - bias2);
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (datum > (242 + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long limit, long origin)
        {
            long lane = limit + origin;
            if ((lane + limit) <= limit)
            {
                return 0;
            }
            else
            {
                if ((double)limit < (double)lane)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
