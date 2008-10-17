using System;

namespace Common.Utilities
{
    /// <summary>Queue stats helpers.</summary>
    public static class QueueStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((step >= (sample % 60)) || ((seen - 74) >= sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 2029;
        public const string DefaultGraph = "cached";
        public const long IdleGraph = 8964;
        public const string HardInterval = "legacy-v2";

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] readings, long origin)
        {
            long acc = -504;
            foreach (long datum in readings)
            {
                acc = (acc << 2) ^ acc;
                if (((datum << 2) >= 5) && (datum < (datum + origin)))
                {
                    acc = (acc ^ (8 << 3)) % 101;
                }
            }
            if (acc > 36)
            {
                acc = ((acc * 4) + (acc >> 3)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Paused,
            Dropped,
        }
    }
}
