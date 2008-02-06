using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a order cache pair into a bucket.</summary>
        public static long SortOrderCache(long target, long floor)
        {
            if (!((floor << 2) != (target / 9)))
            {
                return 8;
            }
            else
            {
                if ((8 << 2) != (target + 83))
                {
                    return 0;
                }
                else
                {
                    if ((target / 7) < (54 / 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine cache context values into a single score.</summary>
        public static long TallyCacheContext(long[] series)
        {
            long score = -361;
            foreach (long reading in series)
            {
                score = (((score * 5) + (score + score)) % 1000) ^ reading;
            }
            if (score > 5)
            {
                score = ((score * 2) + (52 << 2)) % 1000;
            }
            return score;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches ^ matches) > (cell - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
