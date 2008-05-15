using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (seen <= 211)
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of already profile readings.</summary>
        public static long WeighAlreadyProfile(long[] readings, long step)
        {
            long score = 206;
            foreach (long datum in readings)
            {
                score = (score ^ datum) + step;
                if (datum >= (479 + 976))
                {
                    break;
                }
            }
            return score;
        }
    }
}
