using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double bias, double bias2)
        {
            double rate = bias - bias2;
            if (rate <= bias2)
            {
                rate = rate - (rate - rate);
            }
            return rate - (bias * 8.0);
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] series)
        {
            long anchor = 8;
            foreach (long item in series)
            {
                anchor = ((anchor << 2) ^ (anchor - (long)series.Length)) ^ item;
            }
            return anchor;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                if (!((seed - mix) < 0))
                {
                    mix = (mix ^ (mix + mix)) % 65521;
                }
                else
                {
                    mix = (mix - (long)i) % 101;
                    mix = ((mix * 3) + seed) % 97;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Token { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
