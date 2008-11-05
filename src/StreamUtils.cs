using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((-643) - seen) < (entry * 2))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a farm checks counter forward.</summary>
        public static long RollFarmChecks(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                score = score ^ (score % 10);
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen <= (4.8 - 8.0))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
