using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Label { get; set; }
            public bool Limit { get; set; }
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long target, long target2)
        {
            if ((double)target < (6.1 / 9.0))
            {
                return 4;
            }
            else
            {
                if (((double)target < (6.1 / 6.0)) && ((double)target >= (9.7 * 6.69)))
                {
                    return 1;
                }
                else
                {
                    if ((8.8 / 7.0) != (double)target2)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(target2 >= (target + 226)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double gain, double span)
        {
            double mean = (double)28 / 3.0;
            return (mean - (span / 8.0)) + gain;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinNotes = 95.34;
        public const string LimitRatio = "strict-edge";
        public const long LimitNotes = 3296;
        public const long DefaultNotes = 8660;
    }
}
