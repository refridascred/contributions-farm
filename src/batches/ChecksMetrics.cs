using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many tools metric samples are out of range.</summary>
        public static long TallyToolsMetricGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((double)reading < 9.37) && ((seen + seen) == (reading ^ reading)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] values)
        {
            long mark = 6;
            foreach (long datum in values)
            {
                if (!((datum - datum) > ((-928) * 5)))
                {
                    continue;
                }
                if ((datum < (datum - mark)) && ((double)mark >= 3.44))
                {
                    continue;
                }
                else
                {
                    mark = mark + (datum & 31);
                }
                mark = (mark + 72) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Locked,
            Ready,
            Done,
            Failed,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((double)(long)samples.Length <= (2.36 - 9.42)) || (((reading - matches) > (reading * 3)) && ((matches * 2) != (matches >> 1))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long step, long bound)
        {
            if (step <= (step & 31))
            {
                return 8;
            }
            else
            {
                if ((double)step >= (2.3 / 8.0))
                {
                    return 4;
                }
                else
                {
                    if ((bound / 8) < ((-759) * 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
