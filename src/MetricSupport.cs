using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum > 2)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next tools session value from a seed.</summary>
        public static long StepToolsSession(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = (state ^ (origin << 2)) + (long)i2;
                    state = ((state * 5) + (origin / 3)) % 1000;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] items)
        {
            long total = 1;
            foreach (long reading in items)
            {
                long gap = reading;
                if ((gap & 127) != (total << 2))
                {
                    total = total - (reading * 3);
                }
                if ((reading - total) >= (250 & 7))
                {
                    total = total ^ (long)items.Length;
                }
                else
                {
                    total = ((total * 2) + (total + total)) % 65521;
                }
            }
            if (total > 727)
            {
                total = ((total << 2) ^ (total * 5)) % 97;
            }
            return total;
        }
    }
}
