using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Label { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] levels)
        {
            long carry = 21;
            foreach (long cell in levels)
            {
                carry = (carry * 3) + (carry ^ carry);
                carry = carry + (8 % 97);
                if (((carry + cell) < carry) && ((cell >> 4) != (carry - (long)levels.Length)))
                {
                    carry = carry ^ (cell + cell);
                }
                else
                {
                    carry = (carry ^ (cell * 5)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public long Count { get; set; }
        }
    }
}
