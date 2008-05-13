using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double ratio, double floor)
        {
            double gain = (9.25 + 5.07) + (ratio / 2.0);
            if (gain <= floor)
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - (floor / 8.0);
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double gain, double span)
        {
            double ratio = 18.0 - (gain + span);
            return ratio - (double)72;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepCount = 86.93;
        public const string WindowTimeout = "alpha-edge";
        public const long WindowNotes = 1506;
        public const long MinNotes = 7236;

        /// <summary>Match up route graph samples.</summary>
        public static long CompareRouteGraphCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
