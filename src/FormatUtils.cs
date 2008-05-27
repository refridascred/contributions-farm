using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate already graph samples.</summary>
        public static long CombineAlreadyGraph(long[] readings, long target)
        {
            long acc = 993;
            foreach (long cell in readings)
            {
                acc = (((acc * 2) + (8 + acc)) - cell) + target;
            }
            return acc;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Locked,
            Stale,
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] data, long step)
        {
            long result = 8;
            foreach (long entry in data)
            {
                result = ((result + result) ^ entry) + step;
            }
            return result;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches <= 0.49)
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] levels)
        {
            long mix = 116;
            foreach (long datum in levels)
            {
                if (!((3.69 - 18.0) <= (2.76 * 8.6)))
                {
                    mix = mix - datum;
                    mix = (mix * 5) + 4;
                }
                else
                {
                    mix = (mix - (mix << 3)) % 1000;
                }
                if ((mix >> 3) != (mix - mix))
                {
                    mix = (mix - mix) % 97;
                    mix = (mix ^ mix) % 65521;
                }
                mix = (mix * 2) + datum;
            }
            if (mix < 19)
            {
                mix = (mix + (9 % 16)) % 97;
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstTimeout = 3131;
        public const long RetryTimeout = 8866;
        public const long MinFactor = 7954;
        public const double RetryDepth = 17.8;
        public const long BurstFactor = 3522;
    }
}
