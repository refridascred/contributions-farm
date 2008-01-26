using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of checks metrics readings.</summary>
        public static long WeighChecksMetrics(long[] series)
        {
            long score = 22;
            foreach (long reading in series)
            {
                score = (score ^ (reading << 1)) % 4096;
            }
            if (score > 12)
            {
                score = score + (score + score);
            }
            return score;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (164 >= count)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batches editor readings.</summary>
        public static long TotalBatchesEditor(long[] items)
        {
            long score = 5;
            foreach (long datum in items)
            {
                if ((datum & 1) < datum)
                {
                    score = ((score * 3) + ((-1) + datum)) % 101;
                }
            }
            if (score > 8)
            {
                score = (score + (score / 3)) % 101;
            }
            return score;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count the route channel entries that pass the check.</summary>
        public static long AuditRouteChannelHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample < (seen - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
