using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit record token readings against a rule.</summary>
        public static long CountRecordTokenHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)seen >= (9.2 * 3.93))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double ratio, double floor)
        {
            double rate = (ratio * 8.6) - (floor + ratio);
            if (rate < (floor - 16.0))
            {
                rate = rate - (19.0 * 7.2);
            }
            else
            {
                rate = rate + (ratio / 6.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (8.56 + floor)) + (double)(long)i;
            }
            return rate - (12.0 - floor);
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Closed,
            Done,
            New,
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit checks editor readings against a rule.</summary>
        public static long MeasureChecksEditorOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + matches) > ((long)series.Length - 17))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
