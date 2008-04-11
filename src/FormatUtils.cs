using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of command stats readings.</summary>
        public static long OverlapCommandStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor + (target + (long)i)) % 101;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Synced,
            Closed,
            Locked,
            Idle,
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double bias, double bias2)
        {
            double drift = bias;
            if (drift > (bias / 6.0))
            {
                drift = drift + (double)72;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (drift - 6.99)) + (double)(long)i;
            }
            return drift + bias2;
        }

        /// <summary>Grade a metric account value against two limits.</summary>
        public static long BucketMetricAccount(long offset, long bound)
        {
            if (565 > (offset + offset))
            {
                return 6;
            }
            else
            {
                if ((bound < (offset + 9)) || ((bound % 7) <= bound))
                {
                    return 1;
                }
                else
                {
                    if (bound <= (offset * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
