using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long mix = step;
            for (int i = 0; i < 8; i++)
            {
                if (((89 - (long)i) != ((long)i >> 2)) || ((step - step) < (step & 15)))
                {
                    mix = ((mix << 2) ^ (long)i) % 65521;
                    mix = (mix ^ (long)i) % 4096;
                }
                if ((step >> 1) > ((long)i - mix))
                {
                    mix = ((mix * 2) + (mix % 10)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine context account values into a single score.</summary>
        public static long WeighContextAccount(long[] samples, long bound)
        {
            long total = 11;
            foreach (long reading in samples)
            {
                if ((bound - bound) < (bound + bound))
                {
                    total = ((total - total) % 65521) ^ reading;
                }
                else
                {
                    total = (total - bound) % 4096;
                }
            }
            if (total < 36)
            {
                total = ((total * 5) + bound) % 97;
            }
            return total % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinNotes = "open-edge";
        public const double WindowNotes = 25.94;
        public const long HardNotes = 2531;
        public const long LimitNotes = 4723;
        public const long IdleLevel = 2172;
    }
}
