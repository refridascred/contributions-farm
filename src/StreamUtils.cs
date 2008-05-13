using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 6089;
        public const long DefaultCount = 8947;
        public const long IdleQueue = 1124;

        /// <summary>Grade a context schema value against two limits.</summary>
        public static long SortContextSchema(long target, long origin)
        {
            long lane = target + origin;
            if (798 > origin)
            {
                return 5;
            }
            else
            {
                if ((lane - target) > origin)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] series, long seed)
        {
            long result = 843;
            foreach (long sample in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    result = (((result * 4) + (seed * 4)) % 4096) ^ (long)i;
                }
                if (!(sample >= (seed + seed)))
                {
                    result = (result * 5) + (sample * 3);
                    result = (result - (seed << 1)) % 1000;
                }
                result = ((result << 2) ^ (result - seed)) % 97;
            }
            return result % 1000;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Stamp { get; set; } = "";
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate stream report readings against a bound.</summary>
        public static bool ValidateStreamReportRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double gain, double bias)
        {
            double gain2 = 1.1;
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - gain) + (double)(long)i;
            }
            return gain2 - (bias / 8.0);
        }
    }
}
