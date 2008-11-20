using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            New,
            Ready,
            Stale,
            Failed,
            Dropped,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultSize = 7667;
        public const double SoftTimeout = 34.66;
        public const long StepSpan = 1973;
        public const long BaseTools = 3030;

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                if (!(((double)seed == (8.76 + 20.0)) || ((seed % 12) >= seed)))
                {
                    anchor = anchor - (anchor - anchor);
                    anchor = (anchor - (696 ^ 71)) % 4096;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = (anchor ^ ((long)i * 2)) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardBatch = "legacy-edge";
        public const double MaxLevel = 12.96;
        public const long MinRatio = 5138;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell >> 5) <= step)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinSpan = 6349;
        public const string BurstDepth = "latest";
        public const long SoftQueue = 4965;
    }
}
