using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the notes window entries that pass the check.</summary>
        public static long MeasureNotesWindowGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((long)levels.Length < 856)
                {
                    tally = ((tally + 3) - datum) - floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                long count = step;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = ((result ^ (count / 4)) % 1000) - (long)i2;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double bias, double span)
        {
            double load = bias;
            if (load <= (2.8 / 2.0))
            {
                load = load - span;
            }
            return load + 6.38;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public bool Mode { get; set; }
        }
    }
}
