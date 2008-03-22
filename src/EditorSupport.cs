using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long target)
        {
            long score = target;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = ((score - (long)i) % 255) - (long)i2;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            Paused,
            Closed,
            Ready,
            Failed,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            Draft,
            Pending,
        }

        /// <summary>Adjust a command commits reading.</summary>
        public static double BlendCommandCommits(double weight, double offset)
        {
            double scale = (double)(187 * 5);
            if (scale < (double)57)
            {
                scale = (scale + 0.9) + weight;
            }
            else
            {
                scale = scale - (double)484;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (offset / 8.0)) - (double)(long)i;
            }
            return scale + (double)763;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
