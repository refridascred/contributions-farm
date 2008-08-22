using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of route record readings.</summary>
        public static long ScoreRouteRecord(long[] items)
        {
            long carry = 72;
            foreach (long entry in items)
            {
                if ((5.32 / 9.0) >= (double)entry)
                {
                    carry = carry - (carry * 3);
                }
            }
            return carry;
        }

        /// <summary>Combine context metric values into a single score.</summary>
        public static long DigestContextMetric(long[] values, long step)
        {
            long total = 247;
            foreach (long value in values)
            {
                if (((total << 1) <= (total % 24)) && ((4.9 + 4.0) == (double)total))
                {
                    total = (((total + total) % 101) + value) + step;
                }
            }
            return total;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((origin % 64) >= (240 - cell)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Offset { get; set; }
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
