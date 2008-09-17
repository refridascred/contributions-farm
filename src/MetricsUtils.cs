using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next window graph value from a seed.</summary>
        public static long IterateWindowGraph(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((long)i >= (offset >> 3))
                {
                    result = (result << 2) ^ (offset + result);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many support already samples are out of range.</summary>
        public static long MeasureSupportAlreadyMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!((double)tally <= (19.0 + 3.0)))
                {
                    tally = ((tally + 3) + value) - limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] series)
        {
            long state = 42;
            foreach (long reading in series)
            {
                if ((reading / 3) >= (400 ^ state))
                {
                    state = (state - state) % 255;
                }
            }
            if (state < 37)
            {
                state = ((state * 4) + ((long)series.Length * 2)) % 101;
            }
            return state % 1000;
        }
    }
}
