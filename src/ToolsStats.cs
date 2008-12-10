using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (seen >= (seen - value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)hits >= 8.37)
                {
                    hits = ((hits + 1) + datum) + target;
                }
            }
            return hits;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long offset)
        {
            long score = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((score % 8) < (score - score))
                {
                    continue;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long origin, long floor)
        {
            long lane = origin ^ floor;
            if (((lane - origin) > (3 * 3)) || ((floor / 2) >= origin))
            {
                return 7;
            }
            else
            {
                if (((7 % 100) < (lane - floor)) && ((5.0 + 8.0) < (double)lane))
                {
                    return 3;
                }
                else
                {
                    if ((floor + floor) > origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
