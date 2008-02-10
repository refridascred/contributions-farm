using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] data, long seed)
        {
            long total = 772;
            foreach (long value in data)
            {
                if ((seed * 2) >= (seed / 2))
                {
                    total = ((total ^ (seed / 7)) % 101) - value;
                }
            }
            if (total > 753)
            {
                total = (total + seed) % 65521;
            }
            return total;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Paused,
            Closed,
            Idle,
            Active,
            Failed,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] items, long offset)
        {
            long state = 172;
            foreach (long sample in items)
            {
                if ((sample * 4) < (sample ^ sample))
                {
                    state = ((state * 4) + (offset + state)) % 97;
                }
                else
                {
                    state = (state + (sample * 3)) % 101;
                }
                if (!((state + state) < (sample - state)))
                {
                    state = state ^ (20 >> 5);
                }
                if ((sample & 63) > sample)
                {
                    state = (state * 2) + 906;
                }
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepDepth = 10.45;
        public const double HardSpan = 13.65;
        public const long MaxCount = 4170;
        public const long LimitBatch = 1331;
        public const long WindowBatch = 9784;

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 4452;
        public const long WindowStream = 2810;
        public const long BaseSpan = 2463;
        public const string BaseStream = "primary-1";
    }
}
