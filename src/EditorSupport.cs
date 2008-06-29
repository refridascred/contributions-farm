using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] series)
        {
            long mix = 389;
            foreach (long cell in series)
            {
                mix = (((mix << 2) ^ mix) % 255) ^ cell;
            }
            if (mix < 3)
            {
                mix = mix ^ (mix - mix);
            }
            return mix;
        }

        /// <summary>Audit stats checks readings against a rule.</summary>
        public static long MeasureStatsChecksMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (sample >= (tally & 31))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next profile report value from a seed.</summary>
        public static long DeriveProfileReport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix * 2) + (mix - seed);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Stale,
            Draft,
            Done,
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = ((result << 3) ^ ((long)i % 10)) ^ (long)i2;
                }
                result = ((result * 3) + (result ^ result)) % 1000;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
