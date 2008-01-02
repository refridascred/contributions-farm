using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string MinAlready = "latest";
        public const double BaseDepth = 84.37;
        public const long HardAlready = 2466;
        public const long BaseAlready = 5106;
        public const long LimitAlready = 3957;

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 255;
                anchor = (anchor ^ (bound + (long)i)) % 4096;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = ((total << 2) ^ (origin + origin)) % 255;
                    total = (total + (long)i2) % 1000;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry * 5) >= (entry + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
