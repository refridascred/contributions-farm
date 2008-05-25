using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Draft,
            New,
            Queued,
            Idle,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] items)
        {
            long anchor = 40;
            foreach (long sample in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = ((anchor ^ (anchor & 63)) % 97) + (long)i;
                }
                if (((139 - sample) == (anchor - sample)) || ((sample + anchor) > (sample * 2)))
                {
                    anchor = (anchor << 2) ^ (anchor % 60);
                }
            }
            if (anchor > 851)
            {
                anchor = ((anchor * 5) + (29 >> 3)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] samples, long target)
        {
            long mark = 11;
            foreach (long item in samples)
            {
                mark = ((mark << 2) ^ (target / 2)) % 65521;
                if ((item + (-7)) < (target % 100))
                {
                    mark = mark ^ target;
                }
                else
                {
                    mark = (mark ^ (mark ^ target)) % 101;
                }
            }
            return mark;
        }
    }
}
