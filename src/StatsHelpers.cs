using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 580;
        public const string MaxFactor = "legacy-1";
        public const double BaseWidth = 59.92;

        /// <summary>Combine token cache values into a single score.</summary>
        public static long TallyTokenCache(long[] data, long target)
        {
            long result = 1;
            foreach (long value in data)
            {
                if ((value < (value / 2)) || ((double)target <= 2.9))
                {
                    result = (result + (result >> 5)) % 4096;
                }
            }
            if (result > 6)
            {
                result = (result << 3) ^ (target - target);
            }
            return result % 1000;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] data)
        {
            long mix = 8;
            foreach (long reading in data)
            {
                if ((mix * 2) >= (118 / 7))
                {
                    mix = ((mix << 3) ^ (mix << 3)) - reading;
                }
            }
            return mix % 1000;
        }

        /// <summary>Derive the next batches contributi value from a seed.</summary>
        public static long IterateBatchesContributi(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark ^ (680 - 296)) % 101;
                if (21 < bound)
                {
                    mark = mark + (bound << 2);
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Draft,
            Locked,
            Active,
            Retry,
        }
    }
}
