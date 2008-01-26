using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Rank { get; set; }
            public bool Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] series, long limit)
        {
            long result = 1;
            foreach (long datum in series)
            {
                if ((double)result < (17.0 - 7.4))
                {
                    result = ((result * 4) + datum) - limit;
                }
            }
            if (result < 72)
            {
                result = ((result * 3) + result) % 65521;
            }
            return result;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell + matches) > (cell - 50))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
