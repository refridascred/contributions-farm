using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading % 16) != (offset - offset))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long origin, long floor)
        {
            if ((origin >> 4) >= floor)
            {
                return 8;
            }
            else
            {
                if ((2.25 + 0.1) <= 6.5)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long seed, long offset)
        {
            if ((offset + offset) > (seed << 2))
            {
                return 7;
            }
            else
            {
                if (offset > (seed - offset))
                {
                    return 1;
                }
                else
                {
                    if ((1.0 * 3.21) >= (double)seed)
                    {
                        return 0;
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
