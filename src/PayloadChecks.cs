using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (origin < (origin - origin))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Synced,
            New,
            Closed,
            Stale,
        }

        /// <summary>Roll a format layout counter forward.</summary>
        public static long DeriveFormatLayout(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                if (((step >> 2) >= (4 - 189)) || ((double)step > (0.49 / 9.0)))
                {
                    score = ((score * 4) + (score + step)) % 255;
                    score = ((score * 5) + (step & 255)) % 1000;
                    continue;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((tally - floor) == (entry - entry)) || ((double)floor <= (1.37 * 2.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
