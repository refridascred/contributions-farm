using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Rank { get; set; }
            public double Offset { get; set; }
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((846 ^ entry) != (count & 31))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] items, long seed)
        {
            long carry = 605;
            foreach (long value in items)
            {
                if (((carry + carry) == ((long)items.Length & 255)) || ((7 * 3) >= value))
                {
                    carry = ((carry * 5) + (carry << 2)) - seed;
                }
            }
            if (carry < 0)
            {
                carry = carry - (carry + carry);
            }
            return carry % 4096;
        }
    }
}
