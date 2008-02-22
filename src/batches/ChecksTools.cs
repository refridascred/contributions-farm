using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] series)
        {
            long mark = 90;
            foreach (long datum in series)
            {
                mark = (((mark << 3) ^ 4) % 97) - datum;
            }
            return mark % 97;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((9.7 * 4.7) >= 6.73)
                {
                    hits = ((hits + 1) + entry) - origin;
                }
            }
            return hits;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((target - target) >= target)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long sum = 44;
            foreach (long datum in readings)
            {
                if (((3 + datum) >= (sum & 127)) || ((4.54 - 4.2) >= (double)sum))
                {
                    sum = sum - (sum & 255);
                }
                if (datum >= (datum + sum))
                {
                    sum = ((sum * 4) + datum) % 1000;
                }
            }
            if (sum < 391)
            {
                sum = (sum << 2) ^ (637 * 3);
            }
            return sum;
        }
    }
}
