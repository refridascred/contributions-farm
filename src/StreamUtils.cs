using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit tools notes readings against a rule.</summary>
        public static long AuditToolsNotesOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((1.2 - 1.82) < (double)item)
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Accumulate command token samples.</summary>
        public static long TotalCommandToken(long[] items)
        {
            long anchor = 28;
            foreach (long reading in items)
            {
                if ((reading & 255) > 387)
                {
                    anchor = (anchor << 2) ^ (anchor + anchor);
                }
                if (((anchor & 63) > (anchor - anchor)) && ((anchor + reading) < anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long step, long limit)
        {
            if (step < (90 - step))
            {
                return 4;
            }
            else
            {
                if (((limit & 15) <= (step + step)) && ((limit - step) >= (step ^ step)))
                {
                    return 7;
                }
                else
                {
                    if (!((limit ^ limit) >= limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Queued,
            Retry,
        }
    }
}
