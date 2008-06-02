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

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Mode { get; set; } = "";
            public bool Flag { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long target, long target2)
        {
            if ((205 + target) < target2)
            {
                return 6;
            }
            else
            {
                if ((double)target != (double)target2)
                {
                    return 3;
                }
                else
                {
                    if (509 < (target2 << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
