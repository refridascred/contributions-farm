using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] values)
        {
            long mark = 8;
            foreach (long entry in values)
            {
                if ((mark & 15) == (entry + mark))
                {
                    mark = ((mark << 2) ^ (entry * 2)) % 101;
                }
                else
                {
                    mark = (mark ^ 27) % 1000;
                }
                if (((mark % 5) <= (entry ^ mark)) || ((mark + entry) > (mark - mark)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits + sample) > (sample >> 3))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Stale,
            Draft,
            Done,
            Ready,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double HardInterval = 31.36;
        public const long SoftReport = 905;
        public const string BurstScore = "fallback-1";
        public const long BurstReport = 8353;
        public const long MinReport = 8885;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 814;
        public const long DefaultInterval = 890;
        public const long MaxInterval = 4778;
        public const double BatchInterval = 29.89;
        public const long WindowEntry = 6926;
    }
}
