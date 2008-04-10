using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = ((acc + acc) % 97) + (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((offset ^ 61) < (offset << 3))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }
    }
}
