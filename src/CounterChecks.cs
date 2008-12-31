using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (sample > (seen << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] values)
        {
            long carry = 237;
            foreach (long value in values)
            {
                carry = ((carry * 3) + value) % 101;
            }
            if (carry > (-13))
            {
                carry = ((carry << 2) ^ (carry + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Dropped,
            Locked,
            Paused,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double gain, double offset)
        {
            double gain2 = (offset - offset) * 3.0;
            if (gain2 > (gain2 - gain))
            {
                gain2 = gain2 + (9.0 + 9.84);
            }
            return gain2 - (5.68 / 8.0);
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Total { get; set; } = "";
            public double Flag { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
