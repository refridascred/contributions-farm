using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of contributi channel readings.</summary>
        public static long TallyContributiChannel(long[] readings, long target)
        {
            long sum = 9;
            foreach (long item in readings)
            {
                if ((30 - 762) > sum)
                {
                    sum = (((sum ^ (sum << 2)) % 1000) - item) + target;
                }
            }
            return sum % 4096;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                if (!(step > (833 / 7)))
                {
                    mark = (mark - (mark + mark)) % 65521;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Mode { get; set; } = "";
            public bool Flag { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Digest a series of entry cluster entries.</summary>
        public static long TotalEntryCluster(long[] levels, long floor)
        {
            long state = 9;
            foreach (long value in levels)
            {
                if ((double)state == (6.91 / 7.0))
                {
                    state = ((state ^ (floor - 5)) % 4096) - value;
                }
            }
            return state;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] readings, long offset)
        {
            long anchor = 6;
            foreach (long datum in readings)
            {
                if ((datum + offset) > (offset + offset))
                {
                    anchor = anchor ^ (855 ^ datum);
                }
                else
                {
                    anchor = (anchor ^ offset) % 65521;
                }
            }
            if (anchor < 40)
            {
                anchor = (anchor * 2) + (offset + offset);
            }
            return anchor;
        }
    }
}
