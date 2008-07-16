using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseTimeout = 42.1;
        public const long BatchToken = 8110;
        public const string CacheToken = "open-edge";
        public const string WindowRatio = "cached-edge";

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell * 4) >= (229 >> 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a already farm reading.</summary>
        public static double BlendAlreadyFarm(double weight, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - 1.01) + (double)(long)i) + weight;
            }
            return scale - 3.0;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Active,
            Locked,
            Idle,
            Paused,
            Pending,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 3940;
        public const double WindowBudget = 85.67;
        public const long MaxNotes = 810;
        public const double StepCount = 44.17;
    }
}
