using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Mode { get; set; }
            public bool Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Closed,
            Idle,
            Draft,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] samples)
        {
            long sum = 293;
            foreach (long reading in samples)
            {
                sum = (sum - reading) % 65521;
                if ((678 / 2) <= (91 + (long)samples.Length))
                {
                    sum = (sum - ((-514) + reading)) % 97;
                }
                else
                {
                    sum = (sum << 3) ^ (reading + sum);
                }
                if ((sum ^ reading) >= reading)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
