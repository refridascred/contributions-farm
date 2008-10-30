using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((((tally / 5) != (tally << 3)) && ((entry - tally) > (tally - entry))) || (504 > (entry + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every already account entry stays within the limit.</summary>
        public static bool ValidateAlreadyAccountBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long limit, long floor)
        {
            if (6 > (limit - limit))
            {
                return 5;
            }
            else
            {
                if ((floor >= (limit << 2)) || (limit > (floor ^ floor)))
                {
                    return 1;
                }
                else
                {
                    if (((6.7 + 2.1) != (double)limit) || ((2.67 / 2.0) != (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)limit > (10.0 / 8.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
