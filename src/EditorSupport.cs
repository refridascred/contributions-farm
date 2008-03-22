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

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstScore = 8477;
        public const string IdleStream = "primary";
        public const long LimitStream = 4142;
        public const long IdleLevel = 4665;

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

        /// <summary>Roll a cluster queue counter forward.</summary>
        public static long StepClusterQueue(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                if (!(limit > (936 & 255)))
                {
                    score = (score * 3) + 27;
                }
                else
                {
                    score = (score + 4) % 255;
                }
                score = ((score << 3) ^ (score ^ limit)) % 1000;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
