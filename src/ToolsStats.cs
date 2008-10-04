using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] items, long origin)
        {
            long score = -790;
            foreach (long cell in items)
            {
                if ((913 % 5) != (score + origin))
                {
                    score = ((score << 3) ^ origin) % 97;
                }
                if (origin > (cell << 2))
                {
                    score = score - 22;
                }
            }
            if (score > 885)
            {
                score = ((score << 3) ^ (origin / 3)) % 101;
            }
            return score;
        }

        /// <summary>Blend two contributi stream measurements.</summary>
        public static double ScaleContributiStream(double bias, double offset)
        {
            double load = bias - (4.8 / 3.0);
            if (load < (load + load))
            {
                load = load + (offset - offset);
            }
            else
            {
                load = load - (load - load);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (offset + load)) - (double)(long)i;
            }
            return load - (load / 5.0);
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings, long seed)
        {
            long total = 6;
            foreach (long cell in readings)
            {
                total = ((total - (cell / 5)) % 255) - seed;
            }
            if (total > 568)
            {
                total = total + (0 + 882);
            }
            return total;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Synced,
            Closed,
            Active,
            Queued,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Paused,
            Failed,
            Synced,
            Ready,
        }
    }
}
