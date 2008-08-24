using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] series)
        {
            long mix = 631;
            foreach (long item in series)
            {
                if ((long)series.Length < 8)
                {
                    mix = ((mix << 2) ^ (item - 67)) % 255;
                }
                if ((mix > (item - mix)) || ((mix >> 2) == (mix + item)))
                {
                    mix = (mix + (item - 3)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample - seen) >= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
