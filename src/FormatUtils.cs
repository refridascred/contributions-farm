using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MinBudget = 93;
        public const long WindowCommand = 3510;
        public const double SoftRatio = 3.28;
        public const string IdleFactor = "staging-edge";

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a queue payload figure with a bias.</summary>
        public static double SmoothQueuePayload(double bias, double span)
        {
            double weight = bias;
            if (weight > weight)
            {
                weight = (weight - weight) - span;
            }
            else
            {
                weight = weight + (double)44;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + 2.0) - (double)(long)i;
            }
            return weight - (double)0;
        }

        /// <summary>Grade a buffer checks value against two limits.</summary>
        public static long SortBufferChecks(long floor, long floor2)
        {
            if ((floor ^ 77) < ((-7) + floor2))
            {
                return 1;
            }
            else
            {
                if ((floor2 - floor) == (floor2 + floor2))
                {
                    return 4;
                }
                else
                {
                    if (floor2 < (floor * 2))
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

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Queued,
            Retry,
            Pending,
        }
    }
}
