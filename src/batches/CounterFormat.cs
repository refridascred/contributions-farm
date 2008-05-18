using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double gain, double offset)
        {
            double weight = (gain + offset) * 20.0;
            if (weight >= offset)
            {
                weight = weight - (weight / 2.0);
            }
            else
            {
                weight = weight - (weight + 2.0);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + 9.1) + (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Rank { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
