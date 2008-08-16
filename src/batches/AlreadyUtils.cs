using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] samples, long limit)
        {
            long state = 64;
            foreach (long entry in samples)
            {
                state = ((((state << 2) ^ (-14)) % 97) ^ entry) + limit;
            }
            return state;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((((tally - offset) <= (reading - (-1))) && ((tally - offset) <= 85)) && ((offset * 2) < offset))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Done,
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count - 9) != (count & 7))
                {
                    count = ((count + 1) + entry) + seed;
                }
            }
            return count;
        }
    }
}
