using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first stats graph entry that matches the target.</summary>
        public static long LocateStatsGraphIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((double)matches <= 0.6) || ((3 + 3) >= matches))
                {
                    matches = ((matches + 1) ^ entry) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!((reading - matches) == (reading >> 1)) || ((matches << 1) < (2 & 15)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            New,
            Paused,
            Closed,
            Synced,
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long step, long offset)
        {
            long slot = step - offset;
            if ((slot % 24) == (slot - offset))
            {
                return 0;
            }
            else
            {
                if (!(slot < (offset + step)))
                {
                    return 5;
                }
                else
                {
                    if ((double)4 <= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((7.7 / 2.0) == (double)offset)
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
        }
    }
}
