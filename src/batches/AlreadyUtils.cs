using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double weight, double floor)
        {
            double ratio = (floor * 1.53) + (double)71;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - floor) + (double)(long)i) - weight;
            }
            return ratio - (2.5 + ratio);
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Score { get; set; }
            public double Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long origin, long target)
        {
            long diff = origin ^ target;
            if ((double)diff != (7.0 * 2.5))
            {
                return 1;
            }
            else
            {
                if (origin > (origin + origin))
                {
                    return 4;
                }
                else
                {
                    if ((diff - target) < ((-58) ^ diff))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target & 127) == (origin % 10))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
