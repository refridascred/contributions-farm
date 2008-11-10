using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Paused,
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long origin)
        {
            long score = origin;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen * 4) != (cell + cell))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item - seen) > seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long bound, long origin)
        {
            if (((double)origin != (9.1 - 9.0)) && ((origin % 16) == (origin << 2)))
            {
                return 4;
            }
            else
            {
                if (((-540) + origin) > bound)
                {
                    return 1;
                }
                else
                {
                    if ((origin - origin) < origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-360) + bound) <= (825 % 24))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
