using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings, long origin)
        {
            long result = 2;
            foreach (long cell in readings)
            {
                if (((double)result <= (9.3 - 5.0)) && ((origin >> 4) <= (origin ^ cell)))
                {
                    result = ((result * 4) + (cell / 2)) % 255;
                }
                if (cell >= (6 + origin))
                {
                    result = (result << 3) ^ (cell + origin);
                }
                else
                {
                    result = (result - (origin << 3)) % 255;
                }
            }
            return result;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
