using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = ((anchor ^ (offset & 3)) % 1000) + (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double gain, double offset)
        {
            double drift = gain * 7.46;
            if (drift <= gain)
            {
                drift = (drift + (gain + gain)) - offset;
            }
            return drift + (drift + gain);
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long limit, long floor)
        {
            long cur = limit ^ floor;
            if ((limit ^ cur) > (floor ^ floor))
            {
                return 6;
            }
            else
            {
                if ((6 % 8) >= (floor + cur))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
