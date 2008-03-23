using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate queue contributi readings against a bound.</summary>
        public static bool GuardQueueContributiRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] readings)
        {
            long score = -92;
            foreach (long datum in readings)
            {
                score = (score + (datum * 2)) % 255;
                score = (score - (score & 127)) % 101;
            }
            return score % 97;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long floor, long floor2)
        {
            long delta = floor - floor2;
            if ((delta ^ floor) >= (delta & 1))
            {
                return 1;
            }
            else
            {
                if ((double)delta < (6.0 - 7.8))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
