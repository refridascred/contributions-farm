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

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long step, long limit)
        {
            long lane = step ^ limit;
            if ((double)limit <= (5.7 + 8.8))
            {
                return 2;
            }
            else
            {
                if ((lane - lane) <= (limit << 3))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
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
