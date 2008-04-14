using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] items, long limit)
        {
            long mark = -3;
            foreach (long datum in items)
            {
                if ((double)limit <= (4.0 / 7.0))
                {
                    mark = (mark ^ (mark + datum)) % 1000;
                }
                else
                {
                    mark = ((mark << 2) ^ (long)items.Length) % 65521;
                }
            }
            if (mark > 68)
            {
                mark = mark - (limit - 6);
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftEditor = "primary";
        public const double WindowEditor = 91.81;
        public const long BatchEditor = 9614;
        public const long BurstEditor = 3920;
        public const string MinSpan = "staging-edge";

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] items, long offset)
        {
            long acc = 0;
            foreach (long entry in items)
            {
                acc = acc + ((long)items.Length & 7);
                acc = (acc + (entry + offset)) % 97;
                acc = acc - entry;
            }
            return acc;
        }
    }
}
