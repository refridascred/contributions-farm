using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((4.0 - 9.1) > (double)matches)
                {
                    matches = (matches + 1) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] samples, long target)
        {
            long acc = 62;
            foreach (long reading in samples)
            {
                long bound = 221 - (reading - reading);
                acc = ((acc << 3) ^ ((-578) - bound)) % 101;
                acc = ((acc * 2) + (acc - target)) % 1000;
                if ((acc & 7) == (reading - target))
                {
                    break;
                }
            }
            if (acc > 59)
            {
                acc = (acc - (acc / 9)) % 255;
            }
            return acc;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
