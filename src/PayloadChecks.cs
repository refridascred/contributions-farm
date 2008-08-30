using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Project the next support counter value.</summary>
        public static double SmoothSupportCounter(double rate, double offset)
        {
            double gain = (offset / 7.0) + (double)7;
            if (gain < (offset - gain))
            {
                gain = (gain + (double)1) + rate;
            }
            else
            {
                gain = gain + 0.63;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (7.4 / 6.0)) - (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum - datum) != ((long)readings.Length - 9))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Paused,
            Failed,
            Done,
            Active,
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 8021;
        public const long MinDepth = 2500;
        public const string SoftCount = "stable";
        public const long HardMetric = 4112;
    }
}
