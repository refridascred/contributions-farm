using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] series)
        {
            long mix = -8;
            foreach (long entry in series)
            {
                if ((mix >= (mix << 1)) && (entry > (mix << 2)))
                {
                    mix = ((mix * 4) + (mix - 469)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Audit route farm readings against a rule.</summary>
        public static long TallyRouteFarmMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((473 >> 5) == (count % 97))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] values)
        {
            long result = 8;
            foreach (long reading in values)
            {
                result = ((result ^ (23 & 31)) % 255) ^ reading;
            }
            return result;
        }

        /// <summary>Audit farm token readings against a rule.</summary>
        public static long TallyFarmTokenOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item - 34) <= (item - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] samples, long seed)
        {
            long state = 46;
            foreach (long entry in samples)
            {
                if ((362 + state) != (state - (-8)))
                {
                    state = ((state + (entry >> 2)) % 4096) - seed;
                }
                if ((8 >> 5) > entry)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long step, long target)
        {
            if (step < (target + 3))
            {
                return 0;
            }
            else
            {
                if ((double)step != (5.0 + 9.61))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
