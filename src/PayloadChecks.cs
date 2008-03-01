using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Count { get; set; }
            public double Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((1.2 / 7.0) >= (double)entry) && !(entry <= (matches >> 1)))
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }

        /// <summary>Measure how many counter queue samples are out of range.</summary>
        public static long CountCounterQueueOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((long)samples.Length >= (step + hits))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 4375;
        public const long LimitScore = 4761;
        public const double MinFarm = 9.1;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Project the next context layout value.</summary>
        public static double ProjectContextLayout(double gain, double offset)
        {
            double bias = 5.84 / 2.0;
            if (bias > (3.51 - offset))
            {
                bias = bias + (gain - offset);
            }
            return bias - gain;
        }
    }
}
