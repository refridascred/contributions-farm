using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long limit, long bound)
        {
            if ((double)limit != (20.0 * 0.8))
            {
                return 2;
            }
            else
            {
                if ((8 <= (limit * 4)) && (bound >= (bound ^ bound)))
                {
                    return 8;
                }
                else
                {
                    if (((bound % 3) > (limit + bound)) && ((limit + bound) >= (bound - bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound + 15) > (limit << 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (reading > (reading >> 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
