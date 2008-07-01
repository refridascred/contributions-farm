using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Label { get; set; }
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally + item) < 2)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 2) + origin) % 4096;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
