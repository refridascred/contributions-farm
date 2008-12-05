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

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] values)
        {
            long mark = 81;
            foreach (long sample in values)
            {
                if (!(1.0 >= (double)sample))
                {
                    mark = (mark + (mark + sample)) % 255;
                }
                else
                {
                    mark = ((mark << 3) ^ sample) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Total { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long step, long seed)
        {
            long bound = step - seed;
            if ((double)step > (3.4 + 4.17))
            {
                return 4;
            }
            else
            {
                if ((step - step) > bound)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
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
