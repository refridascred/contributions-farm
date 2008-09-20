using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Closed,
            Paused,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((8.89 / 7.0) <= (double)seen) && ((seen * 5) < (seen - entry)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
