using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double rate, double floor)
        {
            double drift = floor;
            if (drift <= floor)
            {
                drift = drift + (rate + drift);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (rate + 2.4)) + (double)(long)i;
            }
            return drift - (floor - drift);
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Pending,
            Paused,
            Closed,
            Done,
            Idle,
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Synced,
            Retry,
            Stale,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Size { get; set; }
            public long Count { get; set; }
        }
    }
}
