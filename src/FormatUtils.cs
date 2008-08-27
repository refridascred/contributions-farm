using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] series)
        {
            long state = -90;
            foreach (long sample in series)
            {
                if ((2.75 + 4.94) == (double)sample)
                {
                    state = (state << 2) ^ (state ^ sample);
                }
                else
                {
                    state = ((state * 2) + (sample / 2)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Derive the next cache schema value from a seed.</summary>
        public static long StepCacheSchema(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                carry = carry - carry;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a schema support reading.</summary>
        public static double ProjectSchemaSupport(double ratio, double offset)
        {
            double scale = ratio;
            if (scale > (offset * 11.0))
            {
                scale = scale + (double)75;
            }
            else
            {
                scale = scale - (double)484;
            }
            return scale + offset;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitRatio = 17.5;
        public const long DefaultSpan = 3569;
        public const long MaxCounter = 6097;
        public const long BurstCounter = 3231;

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchSize = "alpha-v2";
        public const long SoftStats = 3118;
        public const long WindowInterval = 3617;
        public const long DefaultStats = 2690;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Queued,
            Locked,
            Dropped,
        }
    }
}
