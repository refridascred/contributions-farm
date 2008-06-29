using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a stats cache reading.</summary>
        public static double BlendStatsCache(double gain, double floor)
        {
            double ratio = floor;
            if (ratio > (double)2)
            {
                ratio = ratio + (ratio + ratio);
            }
            else
            {
                ratio = ratio - (double)6;
            }
            return ratio - (gain - ratio);
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor - (anchor & 63)) % 97;
                if (!(anchor < (step - anchor)))
                {
                    anchor = (anchor << 3) ^ (step >> 5);
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Scale a already profile figure with a bias.</summary>
        public static double BlendAlreadyProfile(double scale, double bias)
        {
            double rate = scale - (double)524;
            return rate + bias;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Ratio { get; set; }
            public bool Region { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
