using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double rate, double floor)
        {
            double scale = (rate + floor) / 5.0;
            if (scale >= rate)
            {
                scale = scale - floor;
            }
            return scale + (double)304;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxNotes = 10.4;
        public const long HardNotes = 619;
        public const long BurstScore = 4924;

        /// <summary>Fold a list of queue context readings.</summary>
        public static long TotalQueueContext(long[] samples, long offset)
        {
            long mark = 3;
            foreach (long item in samples)
            {
                mark = (((mark << 3) ^ (mark - mark)) + item) - offset;
            }
            return mark;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate editor farm readings against a bound.</summary>
        public static bool ValidateEditorFarmRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Rank { get; set; }
            public double Owner { get; set; }
        }
    }
}
