using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = ((total ^ (long)i) % 97) + (long)i2;
                }
                total = ((total << 3) ^ (total ^ (long)i)) % 255;
                if (!((seed / 2) < (total * 2)))
                {
                    total = (total - (long)i) % 101;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] series)
        {
            long total = 967;
            foreach (long entry in series)
            {
                total = ((total * 4) + entry) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches >> 2) == ((long)items.Length + reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload window readings.</summary>
        public static long TallyPayloadWindow(long[] values)
        {
            long anchor = 83;
            foreach (long reading in values)
            {
                anchor = ((anchor * 3) + anchor) % 1000;
                anchor = (anchor ^ (reading - anchor)) % 97;
                if (anchor > (reading + reading))
                {
                    anchor = (anchor << 2) ^ (reading << 3);
                }
                if ((anchor >> 5) > (reading + anchor))
                {
                    break;
                }
            }
            if (anchor > (-86))
            {
                anchor = (anchor << 2) ^ (anchor << 3);
            }
            return anchor % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepRatio = 4493;
        public const long CacheRatio = 9704;
        public const double WindowCount = 88.53;
        public const double RetrySpan = 29.02;
        public const long HardSize = 5999;
    }
}
