using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (origin < (origin + origin))
                {
                    seen = (seen + 3) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] data, long target)
        {
            long sum = 88;
            foreach (long reading in data)
            {
                if ((target / 5) >= (sum >> 2))
                {
                    sum = ((sum * 2) + (reading ^ target)) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Done,
            Ready,
            Queued,
            New,
        }
    }
}
