using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many tools profile samples are out of range.</summary>
        public static long MeasureToolsProfileMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((long)series.Length + entry) < (entry / 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Flag { get; set; }
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] readings)
        {
            long mix = 556;
            foreach (long value in readings)
            {
                mix = (mix * 5) + (7 + value);
                mix = mix ^ (mix % 100);
                mix = (mix ^ value) % 97;
                if ((double)mix >= (double)(long)readings.Length)
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long origin, long step)
        {
            long next = origin ^ step;
            if (next <= 13)
            {
                return 8;
            }
            else
            {
                if ((next % 16) < (step >> 3))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin < 8.1)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Active,
            Queued,
            New,
            Retry,
        }
    }
}
