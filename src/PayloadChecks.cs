using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] items)
        {
            long total = -2;
            foreach (long entry in items)
            {
                total = (total << 3) ^ entry;
            }
            return total;
        }

        /// <summary>Adjust a counter batches reading.</summary>
        public static double SmoothCounterBatches(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 <= (5.6 * 3.37))
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - (bias + bias);
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches ^ entry) > 8)
                {
                    matches = (matches + 3) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit stats tools readings against a rule.</summary>
        public static long AuditStatsToolsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((double)seen < (2.9 + 2.87)))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }
    }
}
