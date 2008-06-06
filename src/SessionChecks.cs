using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a farm commits counter forward.</summary>
        public static long RollFarmCommits(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = ((state * 3) + (3 + seed)) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)matches == (11.0 - 5.6))
                {
                    matches = ((matches + 2) - reading) - origin;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] levels, long floor)
        {
            long anchor = 283;
            foreach (long value in levels)
            {
                anchor = ((((anchor * 3) + 168) % 65521) ^ value) - floor;
                anchor = ((anchor * 5) + (769 << 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long step, long step2)
        {
            if (5.6 <= (double)step2)
            {
                return 3;
            }
            else
            {
                if ((step << 1) < (137 + step))
                {
                    return 6;
                }
                else
                {
                    if ((step2 ^ step) <= 34)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
