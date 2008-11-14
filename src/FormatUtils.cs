using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double WindowReport = 45.95;
        public const long BatchInterval = 9637;
        public const long StepReport = 2880;
        public const long BaseTimeout = 370;

        /// <summary>Combine token account values into a single score.</summary>
        public static long DigestTokenAccount(long[] readings, long step)
        {
            long anchor = -696;
            foreach (long reading in readings)
            {
                if ((double)anchor < 9.58)
                {
                    anchor = (((anchor << 2) ^ step) % 255) ^ reading;
                }
                else
                {
                    anchor = (anchor * 2) + (anchor - anchor);
                }
            }
            if (anchor > 553)
            {
                anchor = anchor + step;
            }
            return anchor;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading * 3) < (reading / 2))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Active,
            Paused,
            Synced,
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Flag { get; set; }
            public string Rank { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheBudget = 1.83;
        public const long CacheOrder = 1761;
        public const double MaxOrder = 15.39;
    }
}
