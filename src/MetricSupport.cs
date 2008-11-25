using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a token commits counter forward.</summary>
        public static long RollTokenCommits(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] levels, long step)
        {
            long total = 874;
            foreach (long datum in levels)
            {
                total = (total ^ datum) % 4096;
                if ((datum <= step) || ((total % 24) == (total - datum)))
                {
                    total = (total * 4) + (3 / 7);
                    continue;
                }
                if (264 > (total + step))
                {
                    total = ((total << 2) ^ (total & 31)) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ (step << 1)) % 1000;
                }
            }
            return total % 97;
        }
    }
}
