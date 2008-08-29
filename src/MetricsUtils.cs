using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftCache = "primary-edge";
        public const long BaseCache = 1837;
        public const double RetryScore = 69.66;
        public const double HardSpan = 89.48;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long target, long seed)
        {
            if ((seed < (target % 64)) || (target >= seed))
            {
                return 3;
            }
            else
            {
                if ((10.0 / 6.0) != (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally + tally) == (entry - entry))
                {
                    tally = (tally + 2) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((bound ^ 529) >= score)
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
