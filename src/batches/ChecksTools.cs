using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Draft,
            Queued,
            Paused,
            Dropped,
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double scale, double floor)
        {
            double mean = scale;
            if (mean >= 1.3)
            {
                mean = mean - mean;
            }
            return mean + (floor + 12.0);
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((12 >= count) && (((5.5 - 5.3) < (6.7 / 6.0)) && (count >= (reading + (-32)))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Label { get; set; }
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
