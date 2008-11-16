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

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
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
