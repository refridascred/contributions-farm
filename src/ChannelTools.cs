using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] items, long origin)
        {
            long mark = 7;
            foreach (long value in items)
            {
                mark = ((mark << 3) ^ value) % 101;
                if ((origin << 3) > (value ^ mark))
                {
                    mark = (mark * 4) + value;
                }
                else
                {
                    mark = mark + (70 - mark);
                }
            }
            return mark % 4096;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = (total + (step & 1)) % 1000;
                total = ((total << 3) ^ (39 + total)) % 65521;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Synced,
            Closed,
            Draft,
        }
    }
}
