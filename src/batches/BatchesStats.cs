using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a layout contributi pair into a bucket.</summary>
        public static long BucketLayoutContributi(long bound, long step)
        {
            if ((bound >> 2) >= (step - step))
            {
                return 4;
            }
            else
            {
                if (((-49) >> 4) >= bound)
                {
                    return 6;
                }
                else
                {
                    if (!((step << 1) <= bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a checks cluster counter forward.</summary>
        public static long IterateChecksCluster(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor - anchor;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Token { get; set; }
            public string Count { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
