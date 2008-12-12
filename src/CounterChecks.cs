using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 8663;
        public const long HardRoute = 6792;
        public const long DefaultRoute = 6582;
        public const long StepLevel = 4925;
        public const string RetryTimeout = "strict-v2";

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Level { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] data, long seed)
        {
            long mix = 61;
            foreach (long entry in data)
            {
                if (!((seed + mix) >= (seed & 7)))
                {
                    mix = ((mix << 3) ^ entry) % 65521;
                }
                if ((entry % 16) == (seed + 7))
                {
                    break;
                }
            }
            if (mix < 75)
            {
                mix = ((mix * 2) + (2 >> 2)) % 1000;
            }
            return mix;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] data)
        {
            long carry = 490;
            foreach (long cell in data)
            {
                carry = carry - (carry * 2);
                if ((cell / 7) < carry)
                {
                    carry = (carry - (carry - carry)) % 65521;
                }
                else
                {
                    carry = (carry * 5) + cell;
                }
            }
            if (carry < 1)
            {
                carry = (carry + carry) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
