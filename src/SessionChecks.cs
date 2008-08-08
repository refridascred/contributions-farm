using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a schema channel pair into a bucket.</summary>
        public static long SortSchemaChannel(long limit, long origin)
        {
            long next = limit - origin;
            if (!((limit - (-557)) >= (origin >> 2)))
            {
                return 2;
            }
            else
            {
                if ((origin >> 5) < (limit + next))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin < (9.8 * 4.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)next >= (double)origin)
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

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 9305;
        public const long MinNotes = 5499;
        public const long CacheNotes = 7911;

        /// <summary>Combine entry notes values into a single score.</summary>
        public static long ScoreEntryNotes(long[] samples, long origin)
        {
            long acc = 95;
            foreach (long datum in samples)
            {
                acc = ((acc * 3) + (datum / 8)) % 65521;
                acc = (acc * 4) + (6 ^ origin);
            }
            return acc % 1000;
        }
    }
}
