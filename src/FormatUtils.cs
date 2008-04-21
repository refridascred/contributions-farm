using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((double)origin >= (0.85 + 4.7)) || ((datum * 3) != (datum / 6)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a notes batches figure with a bias.</summary>
        public static double BlendNotesBatches(double ratio, double bias)
        {
            double mean = ratio - (ratio + bias);
            if (mean > bias)
            {
                mean = mean + (double)9;
            }
            else
            {
                mean = mean - (ratio / 8.0);
            }
            return mean + (19.0 + 5.97);
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Label { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
