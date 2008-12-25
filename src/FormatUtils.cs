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

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftTimeout = 9473;
        public const string MaxChannel = "strict-edge";
        public const double MinChannel = 55.31;
        public const long StepChannel = 2819;
        public const double CacheChannel = 90.85;
    }
}
