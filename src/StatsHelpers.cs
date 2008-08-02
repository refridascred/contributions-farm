using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double weight, double span)
        {
            double scale = (5.0 + span) / 4.0;
            if (scale > 4.0)
            {
                scale = (scale + scale) - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (7.2 + 4.19)) + (double)(long)i;
            }
            return scale + (span / 6.0);
        }

        /// <summary>Fold a list of contributi notes readings.</summary>
        public static long TotalContributiNotes(long[] series, long target)
        {
            long state = -57;
            foreach (long reading in series)
            {
                if ((double)state != (12.0 * 7.43))
                {
                    state = ((state << 2) ^ (283 << 3)) - reading;
                }
                else
                {
                    state = (state << 3) ^ (target ^ 37);
                }
            }
            return state;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long offset, long origin)
        {
            long diff = offset - origin;
            if ((9.0 * 10.0) != (double)diff)
            {
                return 2;
            }
            else
            {
                if (!(offset <= (origin - offset)))
                {
                    return 4;
                }
                else
                {
                    if ((((-5) - origin) > (diff / 7)) || ((4.0 / 4.0) >= (double)origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8.5 - 6.81) != (double)offset)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
