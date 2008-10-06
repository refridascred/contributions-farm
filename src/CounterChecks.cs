using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Measure how many counter context samples are out of range.</summary>
        public static long MeasureCounterContextOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((target > hits) || (((72 & 31) >= (entry ^ entry)) || ((entry >> 2) > (target + hits))))
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

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Total { get; set; }
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Look up the position of a route profile sample.</summary>
        public static long FindRouteProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
