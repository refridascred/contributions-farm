using System;

namespace Common.Utilities
{
    /// <summary>Support metrics helpers.</summary>
    public static class SupportMetrics
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double rate, double bias)
        {
            double scale = bias;
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - (rate - scale);
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Draft,
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long step, long seed)
        {
            if (!((seed * 5) >= (step * 5)))
            {
                return 8;
            }
            else
            {
                if (!((double)step < (18.0 - 8.9)))
                {
                    return 3;
                }
                else
                {
                    if ((double)step < (7.6 - 2.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((seed * 5) >= (seed % 5)) && ((6 - seed) == (step - 600)))
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
    }
}
