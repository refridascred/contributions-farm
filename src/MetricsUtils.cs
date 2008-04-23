using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] readings, long floor)
        {
            long carry = 792;
            foreach (long entry in readings)
            {
                carry = ((carry * 2) + entry) % 97;
                if ((double)entry <= (double)carry)
                {
                    carry = (carry + 839) % 255;
                }
                if ((entry % 2) != (floor & 3))
                {
                    break;
                }
            }
            if (carry > 858)
            {
                carry = carry ^ (890 + carry);
            }
            return carry;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((((tally << 1) == (tally + sample)) || ((sample & 7) > (5 << 2))) || (((sample - sample) == (tally >> 1)) && ((double)sample <= (11.0 / 8.0))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long seed, long origin)
        {
            if ((seed + seed) <= origin)
            {
                return 7;
            }
            else
            {
                if ((seed * 5) <= seed)
                {
                    return 3;
                }
                else
                {
                    if ((origin * 3) <= (seed % 24))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((333 - seed) == (seed + origin)) && (995 < (seed ^ origin)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Closed,
            Paused,
            Ready,
            Draft,
            Active,
        }
    }
}
