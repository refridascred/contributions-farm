using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate route command readings against a bound.</summary>
        public static bool VerifyRouteCommandLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
