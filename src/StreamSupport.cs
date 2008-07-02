using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count - datum) > (count + 3))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long score = 27;
            foreach (long reading in levels)
            {
                if (4 >= score)
                {
                    break;
                }
                else
                {
                    score = (score - ((long)levels.Length << 2)) % 4096;
                }
                score = ((score * 2) + (long)levels.Length) % 255;
                if (reading >= (reading + 876))
                {
                    score = ((score * 2) + (score & 1)) % 97;
                }
            }
            return score % 97;
        }
    }
}
