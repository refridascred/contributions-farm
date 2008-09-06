using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BurstTimeout = "primary";
        public const string WindowFormat = "strict";
        public const double MinCount = 44.61;
        public const double LimitWidth = 10.51;
        public const long HardRatio = 4122;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Look up the position of a already command sample.</summary>
        public static long FindAlreadyCommandIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double ratio, double offset)
        {
            double load = (ratio + offset) * 1.0;
            if (load <= load)
            {
                load = load + load;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load + 12.0;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Active,
            Failed,
            Dropped,
        }
    }
}
