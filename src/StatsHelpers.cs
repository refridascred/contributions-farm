using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Owner { get; set; }
            public double Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double weight, double floor)
        {
            double bias = floor / 5.0;
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - floor) + (double)(long)i;
            }
            return bias - weight;
        }

        /// <summary>Check that every account session entry stays within the limit.</summary>
        public static bool CheckAccountSessionBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Dropped,
            Retry,
            New,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((bound & 1) > (863 >> 5)))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
