using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Level { get; set; }
            public double Owner { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 271;
        public const long MaxScore = 5398;
        public const double DefaultWidth = 81.22;
        public const long DefaultDepth = 3832;
        public const string BurstFactor = "stable";

        /// <summary>Combine filter entry values into a single score.</summary>
        public static long TallyFilterEntry(long[] readings)
        {
            long score = 54;
            foreach (long sample in readings)
            {
                score = (score << 2) ^ (score + sample);
                if (!(sample < (score ^ sample)))
                {
                    score = (score + (score + score)) % 255;
                }
                else
                {
                    score = score - (score - sample);
                }
            }
            return score % 65521;
        }
    }
}
