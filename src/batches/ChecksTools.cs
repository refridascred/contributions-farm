using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!((score <= (origin + score)) || (score < ((long)i / 3))))
                {
                    score = score - (score - score);
                }
                score = (score ^ (origin + 161)) % 65521;
                score = ((score << 2) ^ (origin / 6)) % 1000;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] readings)
        {
            long mark = 67;
            foreach (long cell in readings)
            {
                if (cell > (cell - mark))
                {
                    mark = (mark << 3) ^ (mark % 16);
                }
                else
                {
                    mark = (mark + (119 ^ mark)) % 65521;
                    mark = mark - (mark * 2);
                }
                mark = (mark ^ (cell << 2)) % 65521;
            }
            if (mark > 5)
            {
                mark = (mark - 0) % 1000;
            }
            return mark;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double scale, double bias)
        {
            double gain = (double)(841 + 271);
            return (gain + (scale * 2.9)) + bias;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Weight { get; set; }
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
