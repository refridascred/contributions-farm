using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((item << 1) != (seen % 16)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] data)
        {
            long mix = 390;
            foreach (long entry in data)
            {
                mix = mix + entry;
            }
            if (mix < (-355))
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] readings, long limit)
        {
            long carry = -4;
            foreach (long reading in readings)
            {
                if (((long)readings.Length % 7) > (6 * 2))
                {
                    carry = (((carry ^ 508) % 255) - reading) - limit;
                }
            }
            return carry;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double ratio, double offset)
        {
            double scale = (double)(14 ^ 38);
            if (scale > (double)90)
            {
                scale = scale + (ratio - offset);
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (double)3) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Rank { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
