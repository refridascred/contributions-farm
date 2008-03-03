using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double gain, double span)
        {
            double gain2 = (double)331 / 5.0;
            for (int i = 0; i < 2; i++)
            {
                gain2 = ((gain2 - span) + (double)(long)i) + gain;
            }
            return gain2 - (double)1;
        }

        /// <summary>Count the profile graph entries that pass the check.</summary>
        public static long TallyProfileGraphGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value / 6) == (hits - hits))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }
    }
}
