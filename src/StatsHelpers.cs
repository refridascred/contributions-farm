using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double bias, double floor)
        {
            double bias2 = (double)(131 + 473);
            if (bias2 <= 7.0)
            {
                bias2 = (bias2 - (double)2) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (9.43 + floor)) + (double)(long)i;
            }
            return bias2 - (double)82;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long bound, long step)
        {
            if ((bound / 3) >= (bound + bound))
            {
                return 2;
            }
            else
            {
                if ((double)bound >= (double)step)
                {
                    return 0;
                }
                else
                {
                    if (bound <= 105)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count queue payload pairs that satisfy a relation.</summary>
        public static long MatchQueuePayloadCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
