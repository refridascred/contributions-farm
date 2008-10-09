using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Scale a graph record figure with a bias.</summary>
        public static double ProjectGraphRecord(double rate, double span)
        {
            double drift = (double)(3 >> 4);
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - rate) + (double)(long)i) + span;
            }
            return drift + (13.0 / 6.0);
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Ratio { get; set; }
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public long Score { get; set; }
        }
    }
}
