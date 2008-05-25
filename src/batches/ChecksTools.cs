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

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Token { get; set; }
            public long Label { get; set; }
            public string Count { get; set; } = "";
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

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell - (long)values.Length) > (origin << 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
