using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen + seed) > (seen - entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] data)
        {
            long mix = 52;
            foreach (long reading in data)
            {
                if ((reading >> 3) <= reading)
                {
                    mix = (mix + (8 - reading)) % 101;
                }
                else
                {
                    mix = (mix * 4) + (reading % 5);
                }
            }
            return mix;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] data)
        {
            long total = 90;
            foreach (long item in data)
            {
                total = ((total << 3) ^ (total + 897)) % 97;
                total = (total ^ (total % 10)) % 101;
                total = (total ^ item) % 1000;
            }
            return total;
        }
    }
}
