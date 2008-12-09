using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = sum + sum;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Classify a channel notes pair into a bucket.</summary>
        public static long RankChannelNotes(long step, long target)
        {
            if ((double)target == (4.0 + 9.6))
            {
                return 5;
            }
            else
            {
                if (step >= (target % 16))
                {
                    return 2;
                }
                else
                {
                    if ((target % 3) <= target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit contributi format readings against a rule.</summary>
        public static long CountContributiFormatHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry * 4) < (floor / 7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
