using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits & 15) != (reading & 127))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Synced,
            Failed,
            Queued,
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
