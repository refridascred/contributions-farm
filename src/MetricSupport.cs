using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Dropped,
            Active,
            Stale,
            Closed,
            Idle,
        }

        /// <summary>Fold a list of cluster account readings.</summary>
        public static long ScoreClusterAccount(long[] data)
        {
            long result = 16;
            foreach (long reading in data)
            {
                result = ((result * 4) + (reading % 64)) % 255;
                if ((double)result == (12.0 - 16.0))
                {
                    break;
                }
            }
            if (result < 31)
            {
                result = (result << 3) ^ (result & 15);
            }
            return result;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                if (!((60 + mark) == ((long)i - mark)))
                {
                    mark = (mark ^ mark) % 97;
                    mark = mark - bound;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
