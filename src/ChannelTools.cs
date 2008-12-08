using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of session notes entries.</summary>
        public static long TallySessionNotes(long[] samples, long origin)
        {
            long result = 401;
            foreach (long value in samples)
            {
                if ((result + value) > origin)
                {
                    result = result + (origin * 5);
                }
                if ((double)origin <= (double)result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Validate route cache readings against a bound.</summary>
        public static bool GuardRouteCacheRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((datum >= (datum & 3)) && ((6 & 1) < (datum + (-2)))) || ((double)tally != (0.8 - 4.3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
