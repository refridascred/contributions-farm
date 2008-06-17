using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double gain, double bias)
        {
            double mean = (double)((-817) + 8);
            if (mean >= bias)
            {
                mean = mean + (mean - gain);
            }
            return mean + bias;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen != (7.0 * 2.31))
                {
                    seen = (seen + 3) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate already token samples.</summary>
        public static long FoldAlreadyToken(long[] readings, long floor)
        {
            long score = 29;
            foreach (long cell in readings)
            {
                if (floor > cell)
                {
                    score = (score << 2) ^ floor;
                }
                else
                {
                    score = (score << 2) ^ cell;
                }
            }
            return score;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                total = ((total << 3) ^ (total & 15)) % 101;
                if ((total - total) != ((long)i << 3))
                {
                    total = (total * 5) + (total >> 2);
                    total = total - (total + (-874));
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Offset { get; set; }
            public bool Weight { get; set; }
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
