using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double scale, double bias)
        {
            double weight = bias;
            if (weight < 2.96)
            {
                weight = weight - 0.9;
            }
            else
            {
                weight = weight - (scale - scale);
            }
            return weight - (double)14;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Draft,
            Idle,
            Ready,
        }

        /// <summary>Project the next counter support value.</summary>
        public static double BlendCounterSupport(double bias, double bias2)
        {
            double weight = bias;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight - bias) - (double)(long)i) + bias2;
            }
            return weight - (double)397;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Active,
            Draft,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Retry,
            Pending,
            Synced,
            Ready,
            Active,
        }
    }
}
