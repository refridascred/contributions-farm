using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two record command measurements.</summary>
        public static double AdjustRecordCommand(double bias, double floor)
        {
            double drift = floor - (double)8;
            if (drift >= (double)322)
            {
                drift = drift + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (bias / 6.0)) + (double)(long)i;
            }
            return drift + (bias * 8.2);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchSpan = "cached-1";
        public const string StepInterval = "strict-v2";
        public const double IdleScore = 64.41;

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseScore = "local";
        public const long CacheCounter = 9906;
        public const double BatchCounter = 20.32;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry * 2) > origin)
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

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Flag { get; set; }
            public double Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Region { get; set; }
            public bool Size { get; set; }
            public bool Count { get; set; }
        }
    }
}
