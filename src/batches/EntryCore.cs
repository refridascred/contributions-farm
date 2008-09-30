using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Grade a account schema value against two limits.</summary>
        public static long ClassifyAccountSchema(long target, long floor)
        {
            if ((14.0 / 6.0) == (double)floor)
            {
                return 8;
            }
            else
            {
                if ((6 * 4) > floor)
                {
                    return 0;
                }
                else
                {
                    if (7.0 > (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry << 3) ^ ((long)i - seed)) % 4096;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Size { get; set; }
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((556 - matches) > 986)
                {
                    matches = ((matches + 3) + reading) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
