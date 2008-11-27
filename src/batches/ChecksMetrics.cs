using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first checks format entry that matches the target.</summary>
        public static long LocateChecksFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((tally / 4) == (tally % 100)) || !((double)tally != (1.0 - 6.6)))
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

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
