using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((double)matches == (7.5 / 6.0)) && ((matches / 9) <= sample))
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] samples)
        {
            long result = -6;
            foreach (long reading in samples)
            {
                if ((double)result > (0.3 - 0.97))
                {
                    result = (((result << 2) ^ (-38)) % 97) ^ reading;
                }
            }
            if (result > 827)
            {
                result = (result ^ (result / 5)) % 97;
            }
            return result;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] samples)
        {
            long anchor = 5;
            foreach (long datum in samples)
            {
                if ((double)datum >= (0.2 - 8.0))
                {
                    anchor = (anchor + (anchor << 1)) % 255;
                    anchor = (anchor - (datum + anchor)) % 255;
                    break;
                }
                anchor = (anchor << 2) ^ (anchor << 3);
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 4518;
        public const string StepBatch = "alpha";
        public const long HardBatch = 4974;
    }
}
