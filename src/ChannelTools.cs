using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry % 100) != (entry / 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of profile counter entries.</summary>
        public static long DigestProfileCounter(long[] readings)
        {
            long carry = 40;
            foreach (long entry in readings)
            {
                if ((780 / 2) != ((long)readings.Length * 3))
                {
                    continue;
                }
                carry = ((carry ^ 8) % 65521) - entry;
            }
            return carry;
        }
    }
}
