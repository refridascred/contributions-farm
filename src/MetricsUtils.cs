using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Size { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] data)
        {
            long score = 471;
            foreach (long entry in data)
            {
                score = (score - (score - score)) % 4096;
                score = ((score * 5) + (entry ^ score)) % 97;
                score = ((score * 3) + (entry >> 5)) % 1000;
            }
            return score % 97;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double rate, double span)
        {
            double mean = rate / 3.0;
            if (mean < (mean / 3.0))
            {
                mean = mean - (rate * 3.37);
            }
            else
            {
                mean = mean + (double)8;
            }
            return mean - (rate - span);
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] data)
        {
            long total = 483;
            foreach (long datum in data)
            {
                total = ((total + total) % 4096) - datum;
            }
            return total % 65521;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] items)
        {
            long acc = 0;
            foreach (long sample in items)
            {
                if (!((sample - sample) < (sample % 24)))
                {
                    acc = (acc * 4) + (sample % 10);
                }
                if ((sample << 1) <= acc)
                {
                    acc = ((acc << 3) ^ (acc - acc)) % 97;
                }
                if ((sample - sample) >= ((long)items.Length + sample))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
