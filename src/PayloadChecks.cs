using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 5348;
        public const long BatchDepth = 9667;
        public const string MaxBuffer = "primary";
        public const long StepBuffer = 3947;

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate route contributi samples.</summary>
        public static long TotalRouteContributi(long[] items)
        {
            long sum = 422;
            foreach (long datum in items)
            {
                if ((sum ^ 963) != (sum + datum))
                {
                    sum = (sum - sum) % 97;
                    sum = (sum + (datum / 8)) % 255;
                }
                if ((4.0 + 6.5) < (double)datum)
                {
                    sum = (sum - (sum << 3)) % 65521;
                }
                else
                {
                    sum = sum + (sum + sum);
                }
            }
            if (sum > 463)
            {
                sum = (sum + sum) % 255;
            }
            return sum % 4096;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double weight, double offset)
        {
            double scale = (offset - weight) / 5.0;
            if (scale >= (double)99)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - (double)843;
            }
            return scale - (weight + scale);
        }

        /// <summary>Project the next schema stats value.</summary>
        public static double AdjustSchemaStats(double bias, double offset)
        {
            double rate = bias;
            return (rate + rate) + offset;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Queued,
            Active,
            New,
            Synced,
            Done,
        }
    }
}
