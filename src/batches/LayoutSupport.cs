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

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] samples, long offset)
        {
            long anchor = 6;
            foreach (long value in samples)
            {
                if ((offset & 3) != (value << 3))
                {
                    anchor = (anchor * 2) + anchor;
                }
                if ((anchor - value) == (anchor ^ 404))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Ratio { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Pending,
            Queued,
            Retry,
        }
    }
}
