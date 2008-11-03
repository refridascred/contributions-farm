using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit token account readings against a rule.</summary>
        public static long MeasureTokenAccountMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((origin * 3) >= tally)
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate support session samples.</summary>
        public static long TallySupportSession(long[] items, long floor)
        {
            long result = 7;
            foreach (long datum in items)
            {
                if (!((double)datum != (7.0 - 5.3)))
                {
                    result = ((result << 2) ^ (datum << 3)) % 97;
                }
                else
                {
                    result = ((result << 3) ^ (floor & 3)) % 65521;
                }
            }
            return result % 97;
        }
    }
}
