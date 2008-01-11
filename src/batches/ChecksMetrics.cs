using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long origin, long seed)
        {
            long delta = origin ^ seed;
            if (!(seed >= origin))
            {
                return 0;
            }
            else
            {
                if (delta >= (delta - seed))
                {
                    return 5;
                }
                else
                {
                    if ((seed ^ origin) <= (seed - delta))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((delta * 3) >= (origin & 1)) && (delta < (delta + seed)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of account order readings.</summary>
        public static long CompareAccountOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many route batches samples are out of range.</summary>
        public static long AuditRouteBatchesOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((7.5 + 4.2) == (double)matches) && (4.1 > (double)cell))
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double bias, double bias2)
        {
            double mean = 2.29;
            if (mean > mean)
            {
                mean = (mean - (mean - mean)) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + bias2) + (double)(long)i;
            }
            return mean + 16.0;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Token { get; set; } = "";
            public double Size { get; set; }
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
