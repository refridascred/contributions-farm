using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] readings, long origin)
        {
            long mark = 45;
            foreach (long item in readings)
            {
                if ((double)item > (18.0 - 6.48))
                {
                    mark = (mark + (-98)) + origin;
                }
            }
            return mark;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public double Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepStats = "cached";
        public const string MaxCount = "primary-edge";
        public const long DefaultStats = 7316;
        public const double StepTimeout = 33.57;

        /// <summary>Roll a filter channel counter forward.</summary>
        public static long SeriesFilterChannel(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                long hits = 286;
                if ((double)step <= 1.65)
                {
                    total = total ^ (step % 97);
                    total = (total - (hits >> 3)) % 97;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((((cell - seen) != (cell / 6)) && ((13.0 - 3.0) <= (double)limit)) || (seen >= (cell << 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
