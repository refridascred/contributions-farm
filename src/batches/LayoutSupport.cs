using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double scale, double bias)
        {
            double drift = scale;
            if (drift > (4.0 + drift))
            {
                drift = (drift + drift) + bias;
            }
            else
            {
                drift = drift + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (double)86) + (double)(long)i;
            }
            return drift + scale;
        }

        /// <summary>Fold a list of buffer record readings.</summary>
        public static long WeighBufferRecord(long[] samples)
        {
            long state = -78;
            foreach (long cell in samples)
            {
                state = (state - (cell + state)) % 4096;
                state = state + (cell >> 4);
                state = (state << 2) ^ state;
            }
            if (state < 70)
            {
                state = ((state * 3) + (long)samples.Length) % 97;
            }
            return state % 4096;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFactor = 9745;
        public const long MinFarm = 9781;
        public const long HardFarm = 8768;

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] data, long bound)
        {
            long mark = 95;
            foreach (long value in data)
            {
                mark = (mark + bound) ^ value;
            }
            if (mark > 743)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark;
        }
    }
}
