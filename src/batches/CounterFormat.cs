using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Synced,
            New,
            Idle,
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double gain, double floor)
        {
            double gain2 = gain;
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + floor) - (double)(long)i;
            }
            return gain2 + gain;
        }

        /// <summary>Accumulate command filter samples.</summary>
        public static long WeighCommandFilter(long[] levels)
        {
            long acc = 90;
            foreach (long datum in levels)
            {
                if ((datum + datum) >= datum)
                {
                    acc = (acc - (datum ^ acc)) % 101;
                }
                if (acc < datum)
                {
                    acc = acc - (datum + datum);
                }
            }
            return acc % 4096;
        }
    }
}
