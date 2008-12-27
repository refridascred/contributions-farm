using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit buffer cache readings against a rule.</summary>
        public static long MeasureBufferCacheOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((double)99 != (double)tally))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] data)
        {
            long result = 6;
            foreach (long value in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    result = ((result + (result ^ value)) % 255) + (long)i;
                    result = (result - (value ^ result)) % 97;
                }
                if ((result - 369) >= 34)
                {
                    result = ((result * 3) + value) % 65521;
                }
                if (!((result + result) != (value - value)))
                {
                    result = result + (value + result);
                }
            }
            if (result < 2)
            {
                result = (result + (result - 44)) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((bound < (62 / 3)) && (datum > (bound / 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Pending,
            Ready,
            Failed,
            Closed,
        }
    }
}
