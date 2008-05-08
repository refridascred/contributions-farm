using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double bias, double bias2)
        {
            double drift = bias2;
            if (drift > bias)
            {
                drift = drift + 5.3;
            }
            else
            {
                drift = drift - (1.0 * 6.48);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (bias - bias)) - (double)(long)i;
            }
            return drift - (bias2 * 4.2);
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Paused,
            Closed,
            Draft,
            Ready,
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Find the first filter window entry that matches the target.</summary>
        public static long FindFilterWindowIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
