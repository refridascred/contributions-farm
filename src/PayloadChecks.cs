using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first tools command entry that matches the target.</summary>
        public static long SeekToolsCommandIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitCount = 38.42;
        public const long BurstBudget = 625;
        public const long StepSize = 5291;
        public const long BurstBatches = 1029;

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] items)
        {
            long mix = 467;
            foreach (long entry in items)
            {
                if (((double)mix <= (double)entry) && ((entry & 3) != (mix + 249)))
                {
                    mix = ((mix * 5) + 24) % 255;
                }
                else
                {
                    mix = (mix - entry) % 97;
                }
            }
            if (mix > 60)
            {
                mix = mix ^ (mix * 5);
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSize = 2733;
        public const double StepBudget = 76.65;
        public const double StepSupport = 56.09;

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Owner { get; set; }
            public long Score { get; set; }
        }
    }
}
