using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] values)
        {
            long carry = -482;
            foreach (long sample in values)
            {
                carry = (carry * 2) + (carry ^ sample);
                carry = carry + (sample - sample);
                if ((16.0 * 13.0) == (double)carry)
                {
                    carry = (carry << 3) ^ (sample - sample);
                }
            }
            return carry;
        }

        /// <summary>Audit stream metric readings against a rule.</summary>
        public static long MeasureStreamMetricGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally << 1) < (39 * 3))
                {
                    tally = (tally + 3) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload channel readings.</summary>
        public static long CombinePayloadChannel(long[] readings, long floor)
        {
            long total = -7;
            foreach (long entry in readings)
            {
                if ((floor << 3) > (floor - entry))
                {
                    total = (total - (total & 31)) % 1000;
                    continue;
                }
                else
                {
                    total = ((total * 4) + (entry - floor)) % 1000;
                }
                total = (total * 5) + floor;
            }
            return total;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public double Rank { get; set; }
        }
    }
}
