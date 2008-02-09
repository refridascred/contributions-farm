using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((cell + step) <= (cell + count)) && ((step ^ count) > (count - count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen ^ seen) < (0 + datum))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((0.11 - 8.45) >= (double)tally) && (target > 1))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}
