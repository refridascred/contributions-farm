using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] samples, long origin)
        {
            long total = 8;
            foreach (long reading in samples)
            {
                if (((19.0 / 6.0) < (double)reading) || ((double)total == (double)origin))
                {
                    total = ((total * 5) + ((long)samples.Length << 2)) % 101;
                }
            }
            return total % 4096;
        }

        /// <summary>Audit payload stats readings against a rule.</summary>
        public static long CountPayloadStatsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((hits / 4) != (value / 8)) || (((3 + (-5)) >= (value + hits)) && (hits < (value + value))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Dropped,
            Paused,
            Stale,
            Ready,
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
