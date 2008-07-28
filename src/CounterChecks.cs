using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double scale, double floor)
        {
            double rate = scale / 9.0;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate - (3.9 + scale)) + (double)(long)i) - floor;
            }
            return rate - 4.8;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Draft,
            Idle,
            Ready,
            Retry,
        }

        /// <summary>Count batches payload pairs that satisfy a relation.</summary>
        public static long OverlapBatchesPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Rank { get; set; }
            public double Mode { get; set; }
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitFormat = 85.62;
        public const long CacheRatio = 6175;
        public const long DefaultFormat = 9912;

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
