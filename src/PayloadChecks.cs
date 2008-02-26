using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            Synced,
            Done,
            Active,
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Active,
            Draft,
            Ready,
            Locked,
            Stale,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] samples)
        {
            long total = 1;
            foreach (long item in samples)
            {
                total = total ^ (total * 4);
                total = ((total << 2) ^ (total << 3)) % 97;
                if (!(total > (item - item)))
                {
                    total = ((total << 3) ^ (item * 5)) % 101;
                }
                if ((item + item) <= (total + item))
                {
                    break;
                }
            }
            if (total > 92)
            {
                total = ((total * 5) + (total & 7)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] items, long limit)
        {
            long carry = 52;
            foreach (long cell in items)
            {
                if (((-86) % 5) < (cell + 183))
                {
                    carry = (((carry * 3) + (-54)) % 101) + limit;
                    carry = carry + (carry & 31);
                }
                else
                {
                    carry = ((carry * 4) + carry) % 65521;
                    carry = (carry - (carry - carry)) % 101;
                }
                if (((8 + carry) != (cell >> 3)) && ((cell << 3) == (carry / 5)))
                {
                    carry = ((carry * 5) + (0 << 3)) % 97;
                }
            }
            if (carry > 2)
            {
                carry = carry - carry;
            }
            return carry;
        }
    }
}
