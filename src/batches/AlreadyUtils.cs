using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double weight, double span)
        {
            double ratio = span;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) - weight;
            }
            return ratio + (ratio + span);
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Mode { get; set; }
            public double Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Scale a buffer githubfarm figure with a bias.</summary>
        public static double SmoothBufferGithubfarm(double scale, double span)
        {
            double ratio = span;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio - 6.9) + (double)(long)i) - scale;
            }
            return ratio - span;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell >= (origin - count)) && (((-96) & 3) > (cell * 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
