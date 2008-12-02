using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseSpan = "local";
        public const long BurstEntry = 7981;
        public const long HardFactor = 4529;
        public const long DefaultEntry = 8014;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Retry,
            Active,
            Queued,
            Closed,
            Synced,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                if (((5 / 5) < acc) || ((limit * 4) < ((long)i + limit)))
                {
                    continue;
                }
                else
                {
                    acc = ((acc * 2) + (acc + acc)) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] data)
        {
            long state = 94;
            foreach (long reading in data)
            {
                if (reading < (reading ^ state))
                {
                    state = (state + state) % 4096;
                }
            }
            return state;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((target % 12) != (436 / 8)) && (8 > seen))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }
    }
}
