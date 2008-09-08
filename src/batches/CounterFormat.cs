using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] samples)
        {
            long anchor = 67;
            foreach (long reading in samples)
            {
                if ((44 - anchor) > anchor)
                {
                    anchor = (anchor ^ (5 ^ anchor)) + reading;
                }
                anchor = (anchor ^ (anchor / 3)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (sample >= (sample * 3))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((origin / 5) >= (reading >> 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
