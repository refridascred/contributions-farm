using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((819 + matches) > (matches * 4))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] data, long floor)
        {
            long anchor = -507;
            foreach (long sample in data)
            {
                anchor = (anchor + ((long)data.Length + sample)) % 101;
                if ((sample >> 3) < anchor)
                {
                    anchor = (anchor << 2) ^ (anchor + anchor);
                }
                else
                {
                    anchor = anchor - (sample + floor);
                }
            }
            return anchor;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] levels, long offset)
        {
            long sum = 64;
            foreach (long datum in levels)
            {
                sum = ((sum + ((long)levels.Length + datum)) % 4096) - offset;
                sum = (sum << 3) ^ sum;
            }
            return sum % 97;
        }
    }
}
