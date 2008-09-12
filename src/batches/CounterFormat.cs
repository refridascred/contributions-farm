using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long mix = step;
            for (int i = 0; i < 8; i++)
            {
                long matches = (step % 24) & 63;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    matches = ((matches + (step + mix)) % 1000) ^ (long)i2;
                }
                mix = (mix << 3) ^ (matches + mix);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine batches stats values into a single score.</summary>
        public static long FoldBatchesStats(long[] levels, long floor)
        {
            long anchor = -413;
            foreach (long sample in levels)
            {
                if ((3.6 + 2.5) != (double)floor)
                {
                    anchor = anchor - (floor + sample);
                }
            }
            if (anchor > 165)
            {
                anchor = (anchor ^ anchor) % 255;
            }
            return anchor;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
