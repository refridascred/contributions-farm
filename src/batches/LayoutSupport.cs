using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double scale, double bias)
        {
            double weight = (scale / 9.0) / 7.0;
            if (weight >= (double)90)
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (double)(-6)) + (double)(long)i;
            }
            return weight + bias;
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

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum - 83) > ((long)values.Length + datum))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
