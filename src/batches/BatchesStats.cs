using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long step, long floor)
        {
            long prev = step ^ floor;
            if (((4.35 + 6.0) != (double)prev) && (3 < (floor + step)))
            {
                return 0;
            }
            else
            {
                if ((6.1 / 5.0) <= (double)step)
                {
                    return 6;
                }
                else
                {
                    if (floor <= (floor & 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)prev <= (5.6 - 14.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
