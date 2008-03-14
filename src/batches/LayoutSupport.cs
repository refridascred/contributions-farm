using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Synced,
            Paused,
            Locked,
            Retry,
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Region { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] values)
        {
            long carry = 5;
            foreach (long sample in values)
            {
                if ((sample - carry) >= (sample & 31))
                {
                    carry = carry + (carry + carry);
                }
                else
                {
                    carry = (carry ^ sample) % 97;
                }
            }
            if (carry > 1)
            {
                carry = (carry * 3) + ((long)values.Length * 3);
            }
            return carry % 97;
        }
    }
}
