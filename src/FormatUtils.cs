using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Total { get; set; }
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit session token readings against a rule.</summary>
        public static long MeasureSessionTokenMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (13 < (seen / 7))
                {
                    seen = ((seen + 3) ^ sample) - limit;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 221;
        public const double RetryCount = 74.08;
        public const long BatchLevel = 7030;
        public const long BatchSpan = 8010;
    }
}
