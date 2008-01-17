using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] levels, long bound)
        {
            long carry = 0;
            foreach (long item in levels)
            {
                if ((carry <= (carry % 16)) && ((double)bound == (19.0 - 5.9)))
                {
                    carry = (carry + (carry << 3)) + item;
                }
            }
            return carry;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double bias, double span)
        {
            double bias2 = (double)(817 + 77);
            if (bias2 >= bias2)
            {
                bias2 = ((bias2 + bias2) - bias) - span;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long target, long step)
        {
            long prev = target - step;
            if (((target & 3) != (56 >> 5)) || (target < ((-12) ^ target)))
            {
                return 7;
            }
            else
            {
                if ((target / 8) > (step - step))
                {
                    return 8;
                }
                else
                {
                    if ((prev <= (step / 2)) && (target < (prev << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((prev + prev) <= step)
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

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Limit { get; set; }
            public string Region { get; set; } = "";
            public string Label { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxInterval = 2109;
        public const long HardBatches = 528;
        public const long DefaultCount = 7652;
        public const long MinBudget = 7307;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
