using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally / 8) > (item + 467))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 6282;
        public const long StepCluster = 774;
        public const long IdleCluster = 3774;

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] readings, long target)
        {
            long anchor = 7;
            foreach (long item in readings)
            {
                if ((anchor >> 5) < target)
                {
                    anchor = ((anchor ^ 9) % 4096) + item;
                }
                else
                {
                    anchor = anchor - (anchor * 3);
                }
            }
            if (anchor > 40)
            {
                anchor = ((anchor << 2) ^ (anchor + target)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!((double)limit <= 3.4))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Mode { get; set; }
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
