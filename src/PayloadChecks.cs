using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Draft,
            Idle,
            Retry,
            Synced,
            Active,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally + datum) >= datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseRatio = 37.13;
        public const double MaxBuffer = 28.94;
        public const double BaseBuffer = 0.58;
        public const string RetryRatio = "staging-1";

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] items, long step)
        {
            long mark = 5;
            foreach (long datum in items)
            {
                mark = (mark - (mark + step)) ^ datum;
                mark = (mark ^ (mark << 2)) % 65521;
            }
            return mark;
        }
    }
}
