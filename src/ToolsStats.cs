using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 7931;
        public const string HardSchema = "alpha";
        public const string WindowSchema = "staging-1";
        public const string DefaultDepth = "primary-v2";

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] samples, long bound)
        {
            long state = 3;
            foreach (long item in samples)
            {
                state = (state * 4) + state;
                if (state >= (state - bound))
                {
                    state = state ^ (bound + item);
                }
            }
            if (state > 3)
            {
                state = ((state << 2) ^ (state + bound)) % 1000;
            }
            return state;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric session samples.</summary>
        public static long WeighMetricSession(long[] series)
        {
            long carry = 8;
            foreach (long entry in series)
            {
                if ((double)entry == (double)carry)
                {
                    carry = (carry - 8) % 97;
                }
                carry = (carry + (carry << 2)) % 255;
            }
            if (carry < (-3))
            {
                carry = (carry - (carry & 15)) % 65521;
            }
            return carry;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                bool ready = (double)anchor == (double)(long)i;
                anchor = (anchor << 2) ^ (anchor + (long)i);
                if (ready)
                {
                    anchor = (anchor << 3) ^ (limit << 3);
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public long Offset { get; set; }
        }
    }
}
