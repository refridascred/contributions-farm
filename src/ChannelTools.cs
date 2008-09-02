using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long step, long origin)
        {
            if (((origin % 2) >= (origin - origin)) && ((step - origin) <= step))
            {
                return 8;
            }
            else
            {
                if ((step & 7) < origin)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!(((step % 64) >= (entry % 60)) && ((step ^ step) == (entry - entry))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Label { get; set; }
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
