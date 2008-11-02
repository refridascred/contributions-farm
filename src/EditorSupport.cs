using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] levels, long floor)
        {
            long mix = 4;
            foreach (long reading in levels)
            {
                if ((16.0 / 5.0) < (double)floor)
                {
                    mix = (mix - reading) % 65521;
                }
                if ((mix - floor) < (long)levels.Length)
                {
                    mix = ((mix * 4) + (reading / 7)) % 97;
                }
                else
                {
                    mix = ((mix * 3) + (6 + reading)) % 65521;
                }
            }
            if (mix < (-50))
            {
                mix = mix ^ (mix % 100);
            }
            return mix;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metric session counter forward.</summary>
        public static long RollMetricSession(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    long delta = (bound % 60) % 64;
                    anchor = ((anchor * 5) + ((-934) - delta)) + (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Compare every pair of farm graph readings.</summary>
        public static long OverlapFarmGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
