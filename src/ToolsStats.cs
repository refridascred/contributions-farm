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

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] values)
        {
            long acc = 350;
            foreach (long cell in values)
            {
                if ((double)acc < (3.01 / 4.0))
                {
                    acc = (acc * 2) + (acc + acc);
                }
                acc = acc ^ (cell + acc);
            }
            return acc;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Score { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item > (seed << 1)) || (((8 - item) == (seed << 2)) && (17.0 < (double)seed)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long origin, long floor)
        {
            if ((7 - origin) >= floor)
            {
                return 2;
            }
            else
            {
                if ((double)floor <= (double)origin)
                {
                    return 7;
                }
                else
                {
                    if ((floor + floor) <= 35)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
