using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Owner { get; set; } = "";
            public long Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] samples)
        {
            long carry = 69;
            foreach (long item in samples)
            {
                if ((carry << 1) != (item << 2))
                {
                    carry = carry ^ (carry / 9);
                }
                else
                {
                    carry = ((carry << 3) ^ (long)samples.Length) % 65521;
                }
            }
            if (carry > 1)
            {
                carry = carry ^ (carry * 4);
            }
            return carry % 97;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value + tally) > (tally + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Queued,
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample * 4) <= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
