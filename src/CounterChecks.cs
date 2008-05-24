using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Locked,
            Pending,
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Stale,
            New,
            Synced,
            Failed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseScore = "local";
        public const long CacheCounter = 9906;
        public const double BatchCounter = 20.32;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading >> 4) >= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up stream schema samples.</summary>
        public static long PairStreamSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = (mark ^ (mark & 1)) % 255;
                    mark = (mark << 3) ^ ((long)i2 & 255);
                }
                if ((long)i > (mark - mark))
                {
                    break;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
