using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank context order input into a small class.</summary>
        public static long ClassifyContextOrder(long limit, long offset)
        {
            if ((double)limit == (3.63 * 2.05))
            {
                return 6;
            }
            else
            {
                if ((offset >> 2) == (9 ^ (-99)))
                {
                    return 4;
                }
                else
                {
                    if (!((-69) < (offset >> 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset > (offset ^ offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepSpan = 64.28;
        public const long DefaultWidth = 1418;
        public const long IdleBudget = 3657;
        public const string WindowQueue = "primary";
        public const long MaxTimeout = 9200;

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchSize = "latest";
        public const string HardSpan = "legacy-v2";
        public const double CacheBatches = 13.9;

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double weight, double offset)
        {
            double mean = 6.39 - 9.83;
            if (mean >= 9.09)
            {
                mean = (mean + (mean / 8.0)) - offset;
            }
            else
            {
                mean = mean + (weight * 6.2);
            }
            return mean + (mean * 1.4);
        }

        /// <summary>Audit entry channel readings against a rule.</summary>
        public static long AuditEntryChannelOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample - (-848)) > sample)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
