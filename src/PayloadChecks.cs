using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] levels)
        {
            long sum = 88;
            foreach (long item in levels)
            {
                sum = sum ^ (item % 97);
                if ((17.0 / 6.0) < (double)item)
                {
                    sum = ((sum << 2) ^ (sum << 2)) % 65521;
                }
            }
            if (sum > 199)
            {
                sum = ((sum << 2) ^ (0 >> 5)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((988 + 816) <= value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowFarm = "stable-1";
        public const double MaxFarm = 44.94;
        public const long CacheSize = 7632;

        /// <summary>Fold a list of channel batch readings.</summary>
        public static long TallyChannelBatch(long[] readings, long step)
        {
            long result = 94;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = (result - (0 + (long)i)) % 1000;
                }
                if ((sample << 1) > (sample + result))
                {
                    result = result ^ (0 + step);
                }
            }
            return result;
        }

        /// <summary>Accumulate account support samples.</summary>
        public static long ScoreAccountSupport(long[] readings)
        {
            long mix = 678;
            foreach (long cell in readings)
            {
                if (((8.9 - 7.59) > (double)mix) || ((4.92 * 4.45) > (double)cell))
                {
                    mix = (mix + (0 % 10)) % 65521;
                }
                mix = mix - cell;
            }
            if (mix < 62)
            {
                mix = mix - (2 * 5);
            }
            return mix;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheStats = "fallback-edge";
        public const long BatchStats = 1405;
        public const long IdleStats = 8580;
        public const double StepStats = 64.67;
        public const long LimitStats = 3066;
    }
}
