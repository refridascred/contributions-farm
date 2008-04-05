using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count cache payload pairs that satisfy a relation.</summary>
        public static long MatchCachePayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)count >= (4.41 - 11.0))
                {
                    count = ((count + 3) - value) - limit;
                }
            }
            return count;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long limit, long limit2)
        {
            if ((double)limit2 <= (4.0 + 3.17))
            {
                return 2;
            }
            else
            {
                if (76 <= (limit2 % 7))
                {
                    return 1;
                }
                else
                {
                    if ((90 - 4) == (limit + limit2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double gain, double floor)
        {
            double ratio = 3.0;
            if (ratio >= (gain / 8.0))
            {
                ratio = ratio - floor;
            }
            else
            {
                ratio = ratio - gain;
            }
            return ratio + (gain + ratio);
        }
    }
}
