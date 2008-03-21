using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit channel notes readings against a rule.</summary>
        public static long CountChannelNotesHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((((entry % 10) > (entry << 2)) && ((target + 5) < (hits ^ target))) || ((double)hits < (double)6))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long limit, long floor)
        {
            long prev = limit + floor;
            if ((limit + 660) == (prev << 2))
            {
                return 0;
            }
            else
            {
                if ((prev - prev) >= (prev % 24))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] values, long bound)
        {
            long sum = 67;
            foreach (long reading in values)
            {
                sum = (sum ^ (29 + reading)) % 65521;
                if ((reading / 6) >= (sum + 82))
                {
                    continue;
                }
                if (((reading & 3) == ((-640) - reading)) || ((bound + reading) < (bound >> 5)))
                {
                    sum = (sum - bound) % 255;
                }
            }
            if (sum > (-27))
            {
                sum = ((sum * 3) + (69 >> 4)) % 4096;
            }
            return sum % 65521;
        }
    }
}
