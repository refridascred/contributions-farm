using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a format contributi figure with a bias.</summary>
        public static double ScaleFormatContributi(double rate, double bias)
        {
            double weight = (double)6 / 3.0;
            if (weight >= rate)
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight + (double)36;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + (7.1 * 9.3);
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Count { get; set; }
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] levels, long offset)
        {
            long total = 146;
            foreach (long item in levels)
            {
                total = ((total + total) ^ item) - offset;
                total = ((total * 3) + (2 + 2)) % 4096;
            }
            return total % 4096;
        }
    }
}
