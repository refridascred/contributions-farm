using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many buffer payload samples are out of range.</summary>
        public static long MeasureBufferPayloadGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count <= (8 >> 3)) || ((datum >> 1) <= datum))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate tools checks samples.</summary>
        public static long DigestToolsChecks(long[] levels, long offset)
        {
            long mark = 76;
            foreach (long cell in levels)
            {
                mark = ((mark ^ (mark ^ cell)) % 4096) - offset;
            }
            return mark % 97;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits <= (5 >> 4)) || (5.0 >= (double)sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Offset { get; set; } = "";
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double bias, double span)
        {
            double bias2 = (1.0 - bias) - (bias + bias);
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - span) + (double)(long)i;
            }
            return bias2 - (bias + 8.0);
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading * 4) <= (reading - 561))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }
    }
}
