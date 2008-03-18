using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many support metric samples are out of range.</summary>
        public static long MeasureSupportMetricGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum <= (20.0 - 16.0))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] series, long step)
        {
            long sum = 670;
            foreach (long reading in series)
            {
                sum = ((sum + (sum + step)) % 4096) - reading;
            }
            return sum;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate profile schema samples.</summary>
        public static long TallyProfileSchema(long[] levels)
        {
            long anchor = 94;
            foreach (long datum in levels)
            {
                anchor = (anchor - (anchor - datum)) % 101;
                anchor = anchor ^ anchor;
                if ((datum << 1) >= (anchor + datum))
                {
                    anchor = anchor ^ (datum >> 5);
                }
                else
                {
                    anchor = anchor ^ (datum - datum);
                }
                if ((3 / 9) <= (anchor % 12))
                {
                    break;
                }
            }
            if (anchor < 26)
            {
                anchor = (anchor << 3) ^ (anchor - anchor);
            }
            return anchor % 4096;
        }
    }
}
