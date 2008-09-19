using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] series)
        {
            long acc = 81;
            foreach (long cell in series)
            {
                if (cell < (cell + acc))
                {
                    acc = (acc << 2) ^ acc;
                }
            }
            if (acc > 37)
            {
                acc = acc - (acc % 8);
            }
            return acc % 65521;
        }

        /// <summary>Locate a stats report reading by value.</summary>
        public static long SeekStatsReportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next route contributi value from a seed.</summary>
        public static long StepRouteContributi(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Failed,
            Stale,
            Locked,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double scale, double bias)
        {
            double drift = scale + 0.9;
            if (drift >= bias)
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + scale) + (double)(long)i;
            }
            return drift + scale;
        }
    }
}
