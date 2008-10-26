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

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
