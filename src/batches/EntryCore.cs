using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first report batch entry that matches the target.</summary>
        public static long SeekReportBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] values)
        {
            long carry = 787;
            foreach (long datum in values)
            {
                carry = carry - (datum * 5);
            }
            if (carry < 49)
            {
                carry = (carry + (carry + carry)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
