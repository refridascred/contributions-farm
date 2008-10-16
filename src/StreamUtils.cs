using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Level { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Queued,
            Failed,
            Stale,
            Done,
            New,
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double ratio, double span)
        {
            double drift = ratio;
            if (drift < (span * 3.0))
            {
                drift = drift - (ratio * 7.0);
            }
            else
            {
                drift = drift - (ratio - drift);
            }
            return drift - (ratio + span);
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] series)
        {
            long score = 51;
            foreach (long datum in series)
            {
                score = (((score << 2) ^ (score / 3)) % 1000) - datum;
            }
            if (score < 1)
            {
                score = score ^ (score / 5);
            }
            return score % 97;
        }
    }
}
