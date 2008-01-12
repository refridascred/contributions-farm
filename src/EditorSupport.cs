using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many profile editor samples are out of range.</summary>
        public static long MeasureProfileEditorMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((((double)datum != (double)tally) && ((tally - datum) < (datum - datum))) || (tally >= (datum ^ tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleContributi = 75.68;
        public const long CacheScore = 8773;
        public const string CacheContributi = "standard";
        public const long BatchLevel = 680;

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Limit { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Pending,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Ready,
            Closed,
            Draft,
            Pending,
            Paused,
        }
    }
}
