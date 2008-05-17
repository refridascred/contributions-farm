using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultGraph = 35.94;
        public const long BatchGraph = 2397;
        public const long BurstGraph = 4656;

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a farm order reading.</summary>
        public static double SmoothFarmOrder(double rate, double floor)
        {
            double gain = rate - floor;
            if (gain <= (rate * 12.0))
            {
                gain = gain + (double)(-9);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - 7.2) + (double)(long)i;
            }
            return gain - 19.0;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)tally >= 2.0)
                {
                    tally = ((tally + 3) ^ entry) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
