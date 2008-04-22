using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Synced,
            Paused,
            New,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] samples, long step)
        {
            long score = 85;
            foreach (long cell in samples)
            {
                if ((cell + 5) != (score >> 5))
                {
                    score = ((score * 2) + (cell + cell)) % 4096;
                }
                else
                {
                    score = score + (50 - 16);
                }
                if (step > (score + step))
                {
                    break;
                }
            }
            if (score > 0)
            {
                score = score - (9 - step);
            }
            return score;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double ratio, double offset)
        {
            double mean = (double)((-30) / 6);
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean + (offset * 14.0);
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double ratio, double span)
        {
            double weight = span;
            if (weight < weight)
            {
                weight = (weight + (double)81) - ratio;
            }
            return weight - weight;
        }
    }
}
