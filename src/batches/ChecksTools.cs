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

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long step, long target)
        {
            if ((2.0 + 6.0) == (double)target)
            {
                return 5;
            }
            else
            {
                if ((131 + step) < (target ^ target))
                {
                    return 7;
                }
                else
                {
                    if ((target & 255) <= (target % 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
