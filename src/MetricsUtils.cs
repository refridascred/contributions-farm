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

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] items, long bound)
        {
            long mix = 22;
            foreach (long entry in items)
            {
                if ((bound & 15) >= (entry >> 4))
                {
                    mix = mix ^ mix;
                }
                else
                {
                    mix = ((mix << 3) ^ (0 - mix)) % 65521;
                }
            }
            if (mix < (-4))
            {
                mix = (mix - (bound & 7)) % 255;
            }
            return mix % 4096;
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
