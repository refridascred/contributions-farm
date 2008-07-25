using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                if (!((9.34 / 7.0) >= (double)carry))
                {
                    carry = ((carry << 2) ^ (carry + seed)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] samples, long target)
        {
            long anchor = 59;
            foreach (long entry in samples)
            {
                if ((((-947) - anchor) <= anchor) && ((double)entry != (6.22 / 6.0)))
                {
                    anchor = (anchor ^ (entry + 18)) - target;
                }
            }
            if (anchor > 55)
            {
                anchor = anchor + (anchor - anchor);
            }
            return anchor;
        }
    }
}
