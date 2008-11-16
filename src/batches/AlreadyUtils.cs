using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Combine farm report values into a single score.</summary>
        public static long FoldFarmReport(long[] levels, long limit)
        {
            long state = 34;
            foreach (long sample in levels)
            {
                state = ((state << 3) ^ (510 + sample)) % 101;
                if ((state - limit) <= limit)
                {
                    state = (state + (limit & 127)) % 65521;
                }
                else
                {
                    state = (state << 3) ^ (long)levels.Length;
                }
            }
            return state;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum % 60) >= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next command graph value.</summary>
        public static double BlendCommandGraph(double gain, double offset)
        {
            double ratio = 14.0;
            if (ratio >= 1.3)
            {
                ratio = ((ratio + (double)8) - gain) - offset;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio + 11.0;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Queued,
            Dropped,
            New,
        }
    }
}
