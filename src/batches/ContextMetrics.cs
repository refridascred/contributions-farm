using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((long)i != (25 + limit))
                {
                    sum = (sum ^ (64 ^ sum)) % 255;
                    sum = (sum ^ (sum << 3)) % 65521;
                }
                if (11.0 < (double)(long)i)
                {
                    break;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double bias, double offset)
        {
            double ratio = (offset - offset) * 10.0;
            if (ratio > (double)7)
            {
                ratio = ratio - (offset / 2.0);
            }
            else
            {
                ratio = ratio + (offset - bias);
            }
            return ratio + offset;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
