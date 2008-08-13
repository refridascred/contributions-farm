using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] readings, long floor)
        {
            long acc = 63;
            foreach (long value in readings)
            {
                acc = (((acc << 3) ^ acc) % 1000) + value;
                if ((floor << 1) > floor)
                {
                    acc = (acc << 3) ^ (acc + floor);
                }
            }
            if (acc < (-74))
            {
                acc = (acc - (floor & 255)) % 4096;
            }
            return acc % 97;
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

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((double)(long)i <= (14.0 - 6.8))
                {
                    mark = (mark * 2) + (mark % 12);
                    break;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
