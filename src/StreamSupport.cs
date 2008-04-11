using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)offset != (6.0 - 14.0))
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batch session samples.</summary>
        public static long WeighBatchSession(long[] readings, long seed)
        {
            long anchor = 596;
            foreach (long value in readings)
            {
                anchor = (anchor - (long)readings.Length) % 4096;
                if (!((13.0 + 1.0) == (double)anchor))
                {
                    anchor = (anchor ^ (anchor + 5)) % 97;
                }
                if (!(value > seed))
                {
                    anchor = ((anchor << 3) ^ value) % 65521;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (seed - 61)) % 255;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (value >= (limit - limit))
                {
                    matches = matches + 3;
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
