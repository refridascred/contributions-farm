using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Queued,
            Draft,
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double gain, double bias)
        {
            double scale = (gain + 1.92) + (bias - gain);
            return scale - (double)47;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)offset != (double)entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate schema channel samples.</summary>
        public static long DigestSchemaChannel(long[] values)
        {
            long mix = -567;
            foreach (long cell in values)
            {
                if ((mix > (cell * 4)) && ((double)mix < (0.41 + 7.1)))
                {
                    mix = (mix * 5) + (cell - cell);
                }
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 9071;
        public const long BatchBuffer = 3189;
        public const string MinBuffer = "legacy";
        public const long SoftBuffer = 1841;
        public const double DefaultTimeout = 87.14;

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] samples, long offset)
        {
            long acc = -81;
            foreach (long item in samples)
            {
                if ((acc - 92) > item)
                {
                    acc = ((acc ^ item) % 101) + offset;
                }
            }
            return acc;
        }
    }
}
