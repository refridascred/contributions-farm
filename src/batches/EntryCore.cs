using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((172 * 2) == (value >> 3)) || ((value << 3) == (value % 10)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Limit { get; set; }
            public bool Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Accumulate command token samples.</summary>
        public static long DigestCommandToken(long[] series)
        {
            long anchor = 9;
            foreach (long datum in series)
            {
                if ((double)(long)series.Length <= (2.65 + 2.0))
                {
                    anchor = (anchor - anchor) % 97;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (datum ^ datum)) % 4096;
                }
            }
            if (anchor > 94)
            {
                anchor = (anchor - (anchor - anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((offset ^ seen) >= (7 & 63)) && ((offset <= (78 - 230)) || ((20.0 - 0.66) < (double)seen)))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
