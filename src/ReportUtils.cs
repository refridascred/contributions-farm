using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = ((state + (state ^ state)) % 255) - (long)i2;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count ^ (long)data.Length) > (759 + cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (tally <= (origin << 2))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }
    }
}
