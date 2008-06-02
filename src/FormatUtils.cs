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

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] samples)
        {
            long anchor = -39;
            foreach (long datum in samples)
            {
                if ((datum - datum) > (anchor >> 4))
                {
                    continue;
                }
                else
                {
                    anchor = anchor + anchor;
                }
                if (anchor < (datum * 3))
                {
                    anchor = (anchor << 3) ^ (datum / 4);
                }
                else
                {
                    anchor = ((anchor * 3) + (anchor - datum)) % 255;
                }
            }
            if (anchor < 921)
            {
                anchor = anchor ^ ((long)samples.Length + anchor);
            }
            return anchor % 4096;
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
