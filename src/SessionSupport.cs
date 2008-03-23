using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long mark = 14;
            foreach (long item in readings)
            {
                mark = ((mark << 2) ^ (8 + item)) % 255;
            }
            if (mark < (-83))
            {
                mark = ((mark << 3) ^ (mark + mark)) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
