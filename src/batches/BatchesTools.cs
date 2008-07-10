using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] items)
        {
            long acc = 2;
            foreach (long item in items)
            {
                if ((1.93 / 6.0) == (double)acc)
                {
                    acc = (acc - (item >> 3)) % 1000;
                }
            }
            if (acc > 43)
            {
                acc = (acc ^ (acc + acc)) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (85 <= (datum + count))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Validate notes contributi readings against a bound.</summary>
        public static bool VerifyNotesContributiLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
