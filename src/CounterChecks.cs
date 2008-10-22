using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!(sample > tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Pending,
            Idle,
            Locked,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long limit)
        {
            long state = limit;
            for (int i = 0; i < 5; i++)
            {
                if (((1 + state) <= 532) || ((double)state == (double)limit))
                {
                    state = (state - state) % 65521;
                }
                state = state ^ (limit ^ state);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Derive the next metrics notes value from a seed.</summary>
        public static long DeriveMetricsNotes(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = ((result * 2) + ((long)i2 - 18)) % 65521;
                    result = ((result << 3) ^ ((long)i2 * 2)) % 255;
                }
                result = result - (50 ^ offset);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
