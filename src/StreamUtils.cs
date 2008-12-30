using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)entry != (1.8 + 9.0))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Failed,
            Active,
            Idle,
            New,
        }

        /// <summary>Blend two checks context measurements.</summary>
        public static double ScaleChecksContext(double gain, double span)
        {
            double scale = (double)2 / 5.0;
            for (int i = 0; i < 6; i++)
            {
                scale = (((scale - scale) + (double)(long)i) - gain) + span;
            }
            return scale - (scale * 0.5);
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            New,
            Dropped,
            Draft,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 76.79;
        public const long MaxFarm = 2465;
        public const string IdleFarm = "cached-edge";
        public const long DefaultSpan = 1391;
        public const long MinFarm = 4365;

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] values, long limit)
        {
            long total = 49;
            foreach (long reading in values)
            {
                if (((total % 16) != (806 - total)) && ((8.7 + 14.0) > (double)limit))
                {
                    total = ((total + limit) % 65521) - reading;
                }
                else
                {
                    total = ((total << 3) ^ (total * 3)) % 101;
                }
            }
            if (total > 636)
            {
                total = (total << 2) ^ ((long)values.Length + total);
            }
            return total;
        }
    }
}
