using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry & 15) > entry)
                {
                    tally = (tally + 1) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] data)
        {
            long anchor = 6;
            foreach (long item in data)
            {
                if ((item + anchor) >= (anchor << 1))
                {
                    anchor = anchor - anchor;
                    anchor = ((anchor * 5) + (item >> 4)) % 65521;
                }
                if ((54 + 3) >= ((long)data.Length ^ 233))
                {
                    anchor = anchor - (893 + 0);
                }
                if ((466 & 3) != (item % 24))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Classify a context payload pair into a bucket.</summary>
        public static long SortContextPayload(long target, long target2)
        {
            long slot = target + target2;
            if (!(85 >= (8 + slot)))
            {
                return 4;
            }
            else
            {
                if ((slot >> 1) == (target2 >> 1))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
