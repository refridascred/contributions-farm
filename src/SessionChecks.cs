using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] series, long step)
        {
            long mix = -314;
            foreach (long cell in series)
            {
                if (((2.18 / 8.0) == (double)step) || ((step & 1) < (long)series.Length))
                {
                    mix = (((mix << 2) ^ (mix / 9)) % 97) + cell;
                    continue;
                }
                if (((432 + mix) > (step << 3)) || (mix > (step + mix)))
                {
                    mix = (mix << 2) ^ (757 & 1);
                }
                else
                {
                    mix = (mix - ((-81) - mix)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Closed,
            Queued,
            New,
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] values)
        {
            long carry = 86;
            foreach (long reading in values)
            {
                carry = ((carry * 3) + reading) % 1000;
            }
            if (carry < 54)
            {
                carry = (carry * 4) + (carry / 3);
            }
            return carry;
        }
    }
}
