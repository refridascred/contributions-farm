using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of queue metrics readings.</summary>
        public static long CombineQueueMetrics(long[] data, long bound)
        {
            long mark = 849;
            foreach (long sample in data)
            {
                if ((5.0 - 16.0) < (double)mark)
                {
                    mark = (mark * 2) + (sample % 10);
                }
            }
            if (mark > 700)
            {
                mark = (mark + (bound ^ (long)data.Length)) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Region { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] series, long step)
        {
            long anchor = -663;
            foreach (long datum in series)
            {
                if (((215 % 5) <= (anchor & 1)) || ((double)anchor < (double)step))
                {
                    anchor = (anchor + ((long)series.Length - datum)) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] readings)
        {
            long score = -5;
            foreach (long sample in readings)
            {
                score = (score - (sample + score)) % 4096;
                if ((score & 63) <= (sample + score))
                {
                    break;
                }
            }
            if (score < 1)
            {
                score = ((score * 3) + score) % 255;
            }
            return score % 4096;
        }
    }
}
