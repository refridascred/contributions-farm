using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next stats githubfarm value from a seed.</summary>
        public static long RollStatsGithubfarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = (state + (limit / 6)) ^ (long)i2;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 7327;
        public const long RetryInterval = 2325;
        public const double MaxRatio = 74.68;
        public const long LimitRatio = 9278;

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] levels, long step)
        {
            long mix = 32;
            foreach (long reading in levels)
            {
                mix = ((mix * 4) + reading) % 97;
                mix = ((mix << 2) ^ (reading - step)) % 255;
                if ((reading % 10) < (81 * 5))
                {
                    mix = ((mix << 2) ^ (reading / 6)) % 255;
                }
                else
                {
                    mix = (mix ^ (step + step)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
