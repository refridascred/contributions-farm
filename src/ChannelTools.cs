using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many payload format samples are out of range.</summary>
        public static long MeasurePayloadFormatGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((floor / 4) <= ((-697) / 5))
                {
                    hits = (hits + 2) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Pending,
            Draft,
        }

        /// <summary>Fold a list of profile stream readings.</summary>
        public static long TallyProfileStream(long[] series)
        {
            long acc = 82;
            foreach (long datum in series)
            {
                acc = acc - datum;
            }
            return acc;
        }
    }
}
