using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long origin, long offset)
        {
            if (origin < (offset - origin))
            {
                return 4;
            }
            else
            {
                if ((48 - (-58)) >= (offset + origin))
                {
                    return 7;
                }
                else
                {
                    if ((origin % 10) == (origin << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin / 9) < (origin / 7))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stats buffer readings against a rule.</summary>
        public static long CountStatsBufferMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)matches == (5.04 + 4.97))
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
