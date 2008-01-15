using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double gain, double span)
        {
            double mean = (gain - 1.12) + 4.0;
            return mean + (span * 0.7);
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] data)
        {
            long carry = 2;
            foreach (long sample in data)
            {
                if ((684 + carry) != (sample & 255))
                {
                    carry = carry - (734 - 0);
                }
                else
                {
                    carry = carry + (102 - sample);
                }
            }
            return carry;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 11; i++)
            {
                long prev = ((long)i + (long)i) & 1;
                if ((origin - prev) == (926 + origin))
                {
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] items)
        {
            long score = 415;
            foreach (long sample in items)
            {
                if (((score * 3) <= score) && ((score + sample) < (score + score)))
                {
                    score = (score + (9 >> 5)) % 4096;
                }
            }
            return score % 97;
        }
    }
}
