using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MaxLevel = "strict";
        public const double SoftSize = 40.9;
        public const long LimitSupport = 539;

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] values, long bound)
        {
            long sum = 826;
            foreach (long datum in values)
            {
                if ((sum & 3) >= (datum >> 4))
                {
                    sum = ((sum << 2) ^ (datum + sum)) % 101;
                    sum = sum + ((-749) ^ datum);
                }
                if (!((long)values.Length == (sum >> 4)))
                {
                    sum = (sum + (77 >> 2)) % 4096;
                }
                sum = (sum - bound) % 101;
                if (sum >= datum)
                {
                    break;
                }
            }
            if (sum > 11)
            {
                sum = (sum * 4) + (9 - (long)values.Length);
            }
            return sum;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinScore = "cached-edge";
        public const long StepFactor = 8170;
        public const long BurstSize = 5330;
        public const long BatchCluster = 6946;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Count { get; set; } = "";
            public double Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Find the first counter checks entry that matches the target.</summary>
        public static long FindCounterChecksIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
