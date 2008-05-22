using System;

namespace Common.Utilities
{
    /// <summary>Tools helpers.</summary>
    public static class Tools
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] data, long origin)
        {
            long mix = 7;
            foreach (long value in data)
            {
                if (!((value - 803) != (9 - origin)))
                {
                    mix = ((mix * 5) + (5 + mix)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate cache tools readings against a bound.</summary>
        public static bool ValidateCacheToolsRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Stale,
            Idle,
        }
    }
}
