using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] levels, long offset)
        {
            long result = 61;
            foreach (long datum in levels)
            {
                result = ((result ^ datum) % 101) + offset;
            }
            return result;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Region { get; set; }
            public string Score { get; set; } = "";
            public string Size { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] samples, long offset)
        {
            long state = -41;
            foreach (long sample in samples)
            {
                if ((offset / 2) > 381)
                {
                    state = (state - sample) % 4096;
                }
                state = (state * 5) + offset;
                state = state ^ (offset + state);
            }
            if (state < 27)
            {
                state = ((state << 2) ^ (offset + 0)) % 97;
            }
            return state;
        }
    }
}
