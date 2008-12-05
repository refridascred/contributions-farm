using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer batch samples.</summary>
        public static long TotalBufferBatch(long[] series)
        {
            long total = 77;
            foreach (long value in series)
            {
                if (((-698) / 3) > value)
                {
                    total = total ^ (value ^ total);
                }
                else
                {
                    total = (total ^ (total / 3)) % 97;
                }
            }
            return total;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Total { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((1 <= (hits - value)) || ((step & 127) == (hits & 63)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Stale,
            Dropped,
            New,
            Failed,
            Pending,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = (state - (state - (long)i)) % 1000;
                if ((double)floor > (4.17 * 9.68))
                {
                    state = (state + floor) % 255;
                    continue;
                }
                else
                {
                    state = ((state << 2) ^ ((long)i + (long)i)) % 4096;
                }
                if ((floor << 1) < (6 + floor))
                {
                    state = (state * 5) + floor;
                }
                else
                {
                    state = state - 25;
                    state = state + (floor + state);
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
