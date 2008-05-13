using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            New,
            Idle,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Token { get; set; }
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next graph layout value from a seed.</summary>
        public static long StepGraphLayout(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                if (((target << 1) >= (target ^ target)) && ((double)6 == (double)result))
                {
                    result = (result + target) % 255;
                }
                else
                {
                    result = ((result * 2) + (target + 571)) % 101;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public bool Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
