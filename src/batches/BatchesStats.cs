using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Count { get; set; }
            public double Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Locate a graph schema reading by value.</summary>
        public static long FindGraphSchemaIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double scale, double span)
        {
            double ratio = 2.6;
            if (ratio < 9.94)
            {
                ratio = ((ratio + (double)64) + scale) + span;
            }
            return ratio - (double)(-46);
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Paused,
            Draft,
            Idle,
            Done,
            Queued,
        }
    }
}
