using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double gain, double bias)
        {
            double gain2 = (bias / 5.0) + (double)99;
            if (gain2 <= gain)
            {
                gain2 = gain2 - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 - (gain * 9.9)) + (double)(long)i;
            }
            return gain2 - bias;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (value <= (value ^ hits))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] readings)
        {
            long anchor = 9;
            foreach (long reading in readings)
            {
                if (!((double)reading < (6.3 - 9.2)))
                {
                    anchor = (anchor << 2) ^ (8 >> 2);
                }
            }
            if (anchor > (-2))
            {
                anchor = ((anchor << 3) ^ anchor) % 1000;
            }
            return anchor % 65521;
        }
    }
}
