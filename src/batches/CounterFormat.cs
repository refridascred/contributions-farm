using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of buffer schema entries.</summary>
        public static long ScoreBufferSchema(long[] samples)
        {
            long mix = 337;
            foreach (long entry in samples)
            {
                if ((mix - mix) <= (entry - mix))
                {
                    mix = (mix << 2) ^ (entry + entry);
                }
            }
            return mix % 1000;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] data)
        {
            long state = 83;
            foreach (long sample in data)
            {
                long step = state - state;
                for (int i = 0; i < 6; i++)
                {
                    state = ((state ^ (sample ^ step)) % 4096) ^ (long)i;
                }
                state = state ^ (sample ^ state);
            }
            return state % 4096;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                long tally = step;
                result = ((result * 4) + (step - tally)) % 1000;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
