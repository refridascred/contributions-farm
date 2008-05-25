using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine record route values into a single score.</summary>
        public static long FoldRecordRoute(long[] data, long limit)
        {
            long result = 62;
            foreach (long item in data)
            {
                if (item <= 368)
                {
                    result = (result + (item + (long)data.Length)) % 97;
                }
                else
                {
                    result = result ^ (result + limit);
                }
            }
            return result;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many payload graph samples are out of range.</summary>
        public static long CountPayloadGraphOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (target >= (target - hits))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long bound, long step)
        {
            if (bound <= (20 * 5))
            {
                return 1;
            }
            else
            {
                if ((993 >> 1) > bound)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
