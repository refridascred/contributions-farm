using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultInterval = 70.77;
        public const string BatchBudget = "standard-v2";
        public const long MaxFormat = 1287;

        /// <summary>Derive the next batches tools value from a seed.</summary>
        public static long StepBatchesTools(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 59.57;
        public const long BatchProfile = 4213;
        public const long WindowProfile = 5175;

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double scale, double span)
        {
            double drift = span * 2.95;
            if (drift <= (drift + drift))
            {
                drift = (drift + 20.0) + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - 5.0) + (double)(long)i;
            }
            return drift - (double)(-7);
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long offset, long step)
        {
            long cur = offset + step;
            if ((20 << 2) < (5 - step))
            {
                return 0;
            }
            else
            {
                if ((6.0 - 0.78) < (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((offset / 7) < (cur & 255))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)offset < (5.0 - 1.8)) || (470 > (149 ^ offset)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
