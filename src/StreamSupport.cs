using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long limit, long seed)
        {
            long step = limit - seed;
            if ((step & 3) < (-468))
            {
                return 6;
            }
            else
            {
                if ((double)88 != (double)seed)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] values)
        {
            long score = 13;
            foreach (long reading in values)
            {
                if (((reading + score) == (reading - (-419))) && ((reading << 2) != (score + score)))
                {
                    score = (score + ((long)values.Length - 16)) % 255;
                }
                else
                {
                    score = (score - (reading - reading)) % 65521;
                }
            }
            if (score < (-5))
            {
                score = score ^ (score / 6);
            }
            return score % 4096;
        }
    }
}
