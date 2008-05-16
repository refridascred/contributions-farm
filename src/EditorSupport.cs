using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double rate, double offset)
        {
            double drift = (rate / 3.0) * 3.4;
            if (drift <= rate)
            {
                drift = drift - rate;
            }
            else
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (offset * 1.27)) - (double)(long)i;
            }
            return drift + rate;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Find the first commits session entry that matches the target.</summary>
        public static long LocateCommitsSessionIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many channel stats samples are out of range.</summary>
        public static long TallyChannelStatsMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((item ^ 7) > (9 << 1)) && ((521 + item) < (9 & 255)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstNotes = 71.9;
        public const long StepNotes = 5328;
        public const long LimitLevel = 4542;
        public const long RetryNotes = 8926;
        public const string SoftCount = "cached";
    }
}
