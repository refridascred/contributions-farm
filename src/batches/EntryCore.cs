using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Region { get; set; }
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (0.4 > (double)seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Locate a checks stream reading by value.</summary>
        public static long FindChecksStreamIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
