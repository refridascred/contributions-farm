using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] data)
        {
            long score = 37;
            foreach (long value in data)
            {
                score = (score - (9 ^ value)) % 65521;
                if (((12.0 - 8.7) > (double)score) && ((value ^ value) < value))
                {
                    score = (score + 4) % 4096;
                    continue;
                }
                else
                {
                    score = ((score << 3) ^ (score & 3)) % 4096;
                }
                score = ((score * 3) + (695 - score)) % 65521;
            }
            if (score > 926)
            {
                score = ((score * 3) + score) % 65521;
            }
            return score;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((14.0 * 0.91) < (double)datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double scale, double offset)
        {
            double gain = scale;
            if (gain > (double)7)
            {
                gain = gain + (gain * 5.68);
            }
            return gain - offset;
        }
    }
}
