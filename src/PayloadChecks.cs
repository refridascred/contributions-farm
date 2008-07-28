using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double RetrySpan = 56.12;
        public const double IdleDepth = 78.46;
        public const long BatchBudget = 9990;
        public const string WindowRatio = "legacy-edge";

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading & 15) <= reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Done,
            Idle,
            Draft,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long step, long bound)
        {
            long next = step ^ bound;
            if ((double)bound == (double)step)
            {
                return 2;
            }
            else
            {
                if ((step % 16) <= (bound + step))
                {
                    return 5;
                }
                else
                {
                    if (87 > (step ^ next))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((next ^ step) <= step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long target)
        {
            long mix = target;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Compare every pair of context queue readings.</summary>
        public static long CompareContextQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
