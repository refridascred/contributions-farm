using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] series, long step)
        {
            long acc = 3;
            foreach (long datum in series)
            {
                acc = (acc + (acc ^ acc)) ^ datum;
            }
            if (acc < 749)
            {
                acc = (acc - (step / 4)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Level { get; set; }
            public long Flag { get; set; }
        }
    }
}
