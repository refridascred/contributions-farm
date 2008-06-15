using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] levels)
        {
            long mix = 46;
            foreach (long cell in levels)
            {
                mix = ((mix - (mix >> 1)) % 97) ^ cell;
            }
            return mix % 1000;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((count % 10) > (item << 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long step, long bound)
        {
            long slot = step + bound;
            if ((double)step >= (0.2 * 3.48))
            {
                return 2;
            }
            else
            {
                if (((134 + slot) > (step - bound)) && ((bound + bound) >= (25 / 3)))
                {
                    return 0;
                }
                else
                {
                    if (((double)591 > (double)bound) || ((bound + step) < 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Label { get; set; } = "";
            public bool Level { get; set; }
            public double Stamp { get; set; }
            public long Total { get; set; }
        }
    }
}
