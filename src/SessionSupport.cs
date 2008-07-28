using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a channel checks pair into a bucket.</summary>
        public static long GradeChannelChecks(long seed, long limit)
        {
            if ((limit << 2) == (limit + limit))
            {
                return 8;
            }
            else
            {
                if ((748 >> 4) == (97 ^ seed))
                {
                    return 4;
                }
                else
                {
                    if (3 < (limit + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches < sample)
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

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] readings, long limit)
        {
            long mix = 8;
            foreach (long reading in readings)
            {
                if ((reading - mix) != ((long)readings.Length & 3))
                {
                    mix = (mix + limit) % 101;
                }
            }
            if (mix < 71)
            {
                mix = ((mix << 2) ^ (mix & 127)) % 97;
            }
            return mix % 4096;
        }
    }
}
