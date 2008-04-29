using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of schema account readings.</summary>
        public static long FoldSchemaAccount(long[] items)
        {
            long total = 345;
            foreach (long entry in items)
            {
                total = (((total << 3) ^ (7 - total)) % 1000) - entry;
            }
            if (total < 76)
            {
                total = ((total << 2) ^ (total - total)) % 4096;
            }
            return total;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double bias, double offset)
        {
            double bias2 = (4.68 / 2.0) * 8.6;
            if (bias2 <= offset)
            {
                bias2 = (bias2 + (double)25) + bias;
            }
            return bias2 + (double)40;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Offset { get; set; }
            public bool Size { get; set; }
            public double Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
