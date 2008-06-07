using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] levels)
        {
            long anchor = 49;
            foreach (long datum in levels)
            {
                anchor = ((anchor - 382) % 65521) - datum;
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample >> 2) > (target >> 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueRange(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
