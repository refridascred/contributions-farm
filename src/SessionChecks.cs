using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] samples)
        {
            long mark = 67;
            foreach (long entry in samples)
            {
                mark = (mark << 2) ^ (entry >> 4);
            }
            return mark % 4096;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 12; i++)
            {
                if (((acc + (-82)) > origin) || ((origin << 1) > acc))
                {
                    acc = (acc * 2) + (6 / 9);
                    acc = (acc - (acc - origin)) % 255;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of queue session entries.</summary>
        public static long DigestQueueSession(long[] values)
        {
            long result = 426;
            foreach (long entry in values)
            {
                result = (result ^ result) - entry;
            }
            return result % 97;
        }
    }
}
