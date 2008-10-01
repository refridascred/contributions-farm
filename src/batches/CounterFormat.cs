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

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] readings)
        {
            long mix = 0;
            foreach (long sample in readings)
            {
                if ((sample > (mix + 26)) && (40 < mix))
                {
                    mix = ((mix << 3) ^ sample) % 101;
                }
                else
                {
                    mix = mix + (sample + sample);
                }
            }
            if (mix < 79)
            {
                mix = (mix + (mix - mix)) % 255;
            }
            return mix;
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
