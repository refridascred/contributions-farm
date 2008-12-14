using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BatchFormat = 54.38;
        public const long SoftCount = 8303;
        public const double StepFormat = 17.66;
        public const double SoftFormat = 71.0;
        public const double LimitFormat = 46.84;

        /// <summary>Measure how many metric checks samples are out of range.</summary>
        public static long TallyMetricChecksMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches & 127) == ((long)series.Length % 16))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Active,
            Draft,
            Locked,
            Closed,
            New,
        }

        /// <summary>Combine contributi window values into a single score.</summary>
        public static long CombineContributiWindow(long[] levels)
        {
            long mark = 12;
            foreach (long sample in levels)
            {
                mark = ((mark + (651 << 2)) % 4096) ^ sample;
                if ((mark - mark) < (mark + 42))
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = ((mark << 3) ^ (mark % 7)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] readings, long offset)
        {
            long mark = -30;
            foreach (long datum in readings)
            {
                if (!((0.69 / 9.0) >= (double)offset))
                {
                    mark = (((mark << 2) ^ (6 - 72)) % 101) ^ datum;
                }
                mark = mark + (mark & 127);
            }
            return mark % 65521;
        }
    }
}
