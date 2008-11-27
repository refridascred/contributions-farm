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

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((reading ^ tally) >= (reading % 10)) || (((reading + reading) >= tally) && ((double)reading > (14.0 * 5.0))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
