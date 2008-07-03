using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double weight, double span)
        {
            double ratio = 0.51 + (span + 8.5);
            if (ratio >= (double)6)
            {
                ratio = ratio - (ratio - 3.89);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (span - span)) - (double)(long)i;
            }
            return ratio - weight;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many record window samples are out of range.</summary>
        public static long CountRecordWindowMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((15.0 / 8.0) >= (double)matches)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }
    }
}
