using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of queue batch readings.</summary>
        public static long OverlapQueueBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double weight, double floor)
        {
            double drift = 8.0;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - floor) + (double)(long)i) - weight;
            }
            return drift - (double)744;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Token { get; set; }
            public double Label { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((seen << 3) > seen) || (((double)datum != (double)74) || ((seen ^ datum) <= seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a buffer record counter forward.</summary>
        public static long SeriesBufferRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc + (step % 100)) % 101;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
