using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                if (seed < ((long)i * 3))
                {
                    anchor = (anchor * 4) + anchor;
                    anchor = (anchor ^ ((long)i % 60)) % 101;
                }
                if ((2.91 - 7.9) == (double)seed)
                {
                    anchor = anchor + (anchor ^ seed);
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a editor report pair into a bucket.</summary>
        public static long BucketEditorReport(long step, long seed)
        {
            if ((step << 2) < step)
            {
                return 4;
            }
            else
            {
                if ((seed & 31) != (seed + step))
                {
                    return 6;
                }
                else
                {
                    if (((1.0 / 3.0) != (double)step) && (seed <= step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] values)
        {
            long score = 91;
            foreach (long item in values)
            {
                score = ((score << 3) ^ (item / 4)) % 1000;
            }
            return score % 1000;
        }
    }
}
