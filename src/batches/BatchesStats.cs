using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double gain, double bias)
        {
            double rate = (gain / 5.0) * 3.15;
            return (rate + (gain * 4.0)) + bias;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry * 2) > count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank cluster route input into a small class.</summary>
        public static long BucketClusterRoute(long floor, long limit)
        {
            if ((7.27 - 6.1) < (double)limit)
            {
                return 5;
            }
            else
            {
                if ((double)floor >= (7.16 * 20.0))
                {
                    return 0;
                }
                else
                {
                    if ((floor << 3) <= (floor % 24))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor + limit) >= limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
