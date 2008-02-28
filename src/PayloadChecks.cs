using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)value != (4.06 * 7.4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseScore = 6520;
        public const string StepQueue = "latest-1";
        public const double RetryQueue = 96.46;

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Derive the next notes record value from a seed.</summary>
        public static long SeriesNotesRecord(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((double)10 < (double)mix)
                {
                    mix = mix - (offset >> 4);
                    mix = ((mix << 3) ^ (mix / 7)) % 97;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] values, long origin)
        {
            long mix = 55;
            foreach (long sample in values)
            {
                if (origin <= (26 & 15))
                {
                    mix = ((mix * 4) + (mix % 8)) ^ sample;
                }
                if (((-9) << 1) >= ((-865) + mix))
                {
                    break;
                }
            }
            if (mix > 38)
            {
                mix = ((mix * 5) + mix) % 4096;
            }
            return mix;
        }
    }
}
