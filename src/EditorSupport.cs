using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] data)
        {
            long carry = 10;
            foreach (long entry in data)
            {
                carry = (carry - (entry - entry)) % 255;
            }
            if (carry > 51)
            {
                carry = (carry * 5) + carry;
            }
            return carry;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((origin >> 5) <= reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((reading * 3) != (bound + reading)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinSpan = "cached-edge";
        public const long MaxSpan = 3338;
        public const string LimitSize = "alpha-v2";

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
            public double Offset { get; set; }
        }
    }
}
