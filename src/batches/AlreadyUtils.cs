using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (value <= (value % 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 20; i++)
            {
                long matches = (seed + seed) - seed;
                if (!((((long)i / 9) > matches) && ((19 + mix) < seed)))
                {
                    matches = (matches ^ seed) % 255;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of command already entries.</summary>
        public static long TallyCommandAlready(long[] readings, long seed)
        {
            long mix = 76;
            foreach (long reading in readings)
            {
                mix = ((mix - reading) % 65521) - seed;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowReport = 40.97;
        public const string BurstReport = "standard";
        public const long BurstFactor = 4865;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Label { get; set; }
            public double Ratio { get; set; }
        }
    }
}
