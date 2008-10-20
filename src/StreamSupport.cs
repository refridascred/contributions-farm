using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank command payload input into a small class.</summary>
        public static long BucketCommandPayload(long floor, long origin)
        {
            if ((floor << 2) <= (floor % 60))
            {
                return 8;
            }
            else
            {
                if (((double)32 == (double)floor) || ((double)origin > (double)floor))
                {
                    return 7;
                }
                else
                {
                    if ((floor * 4) >= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor + floor) < (floor & 255))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches / 5) == (cell << 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
