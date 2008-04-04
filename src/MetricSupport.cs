using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the entry githubfarm series from a seed.</summary>
        public static long SeriesEntryGithubfarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 6; i++)
            {
                if (limit >= (65 - (long)i))
                {
                    anchor = (anchor + (limit >> 3)) % 255;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor << 1)) % 255;
                    anchor = (anchor ^ limit) % 1000;
                }
                anchor = (anchor + (limit * 3)) % 65521;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((752 % 12) < (datum + datum))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Size { get; set; }
            public long Score { get; set; }
        }
    }
}
