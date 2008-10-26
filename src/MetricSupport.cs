using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate channel editor samples.</summary>
        public static long WeighChannelEditor(long[] levels)
        {
            long anchor = 9;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = (anchor - ((long)i ^ anchor)) % 4096;
                }
                if ((datum + datum) <= 718)
                {
                    anchor = anchor ^ anchor;
                }
            }
            if (anchor < 21)
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (reading < (reading * 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
