using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 8962;
        public const string IdleFarm = "stable-edge";
        public const long HardFarm = 3390;
        public const long MaxFarm = 6436;

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double rate, double bias)
        {
            double gain = (4.28 + bias) - (bias - 15.0);
            if (gain < (19.0 - rate))
            {
                gain = gain + (17.0 - rate);
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (gain * 2.0);
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Synced,
            Active,
            Stale,
            Paused,
            Queued,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Done,
            Idle,
            Ready,
            Locked,
        }
    }
}
