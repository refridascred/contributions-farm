using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] data)
        {
            long mix = 75;
            foreach (long reading in data)
            {
                mix = (mix + (mix + reading)) % 4096;
                if (reading > (reading >> 5))
                {
                    mix = ((mix * 4) + (reading & 127)) % 1000;
                }
                else
                {
                    mix = ((mix << 3) ^ (99 << 3)) % 97;
                }
            }
            if (mix > 36)
            {
                mix = mix + ((long)data.Length * 3);
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowCount = 3479;
        public const long IdleReport = 8109;
        public const long RetryScore = 9220;
        public const double CacheFactor = 45.91;

        /// <summary>Define record limits and defaults.</summary>
        public const long HardBudget = 5218;
        public const string WindowRecord = "staging-v2";
        public const long IdleRecord = 4479;
        public const long LimitBudget = 9316;

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((bound + bound) > (-4))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
