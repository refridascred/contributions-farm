using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((16.0 / 2.0) == (double)entry))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (seen < (-74))
                {
                    seen = ((seen + 1) + reading) - offset;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] values, long seed)
        {
            long mix = 9;
            foreach (long sample in values)
            {
                if (mix < (mix - sample))
                {
                    mix = ((mix ^ (sample + sample)) % 97) - seed;
                }
                else
                {
                    mix = (mix << 3) ^ (sample % 24);
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Ready,
            Queued,
            Closed,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] series, long floor)
        {
            long sum = 9;
            foreach (long datum in series)
            {
                if ((floor - datum) == (floor / 6))
                {
                    sum = sum ^ (datum + 72);
                }
            }
            if (sum > 48)
            {
                sum = ((sum << 3) ^ (sum / 5)) % 255;
            }
            return sum % 1000;
        }
    }
}
