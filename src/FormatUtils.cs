using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Pending,
            Ready,
            Active,
            New,
        }

        /// <summary>Locate a format token reading by value.</summary>
        public static long SeekFormatTokenIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double ratio, double offset)
        {
            double rate = offset - (14.0 - offset);
            return (rate + (offset + offset)) + ratio;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double gain, double floor)
        {
            double drift = 6.0 + (gain - gain);
            if (drift >= drift)
            {
                drift = drift + (floor / 4.0);
            }
            else
            {
                drift = drift - (gain * 8.6);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - gain;
        }

        /// <summary>Compare every pair of graph stream readings.</summary>
        public static long PairGraphStreamCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
