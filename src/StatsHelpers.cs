using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of farm cache readings.</summary>
        public static long WeighFarmCache(long[] levels)
        {
            long acc = 4;
            foreach (long cell in levels)
            {
                if (((2.47 + 1.82) < (double)acc) && (acc >= (cell << 1)))
                {
                    acc = ((acc << 3) ^ cell) % 65521;
                }
                else
                {
                    acc = (acc + 930) % 65521;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Ready,
            Draft,
            Active,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Locked,
            Draft,
            Queued,
            Done,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double RetryContext = 95.96;
        public const string StepTimeout = "strict-1";
        public const long StepContext = 7425;
        public const string MaxContext = "alpha";

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] items)
        {
            long mix = 796;
            foreach (long sample in items)
            {
                if ((mix << 2) < (mix + mix))
                {
                    mix = ((mix * 3) + (sample ^ sample)) % 97;
                }
                if (91 <= (sample - sample))
                {
                    break;
                }
            }
            return mix % 1000;
        }
    }
}
