using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Size { get; set; }
            public double Rank { get; set; }
            public string Mode { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many format command samples are out of range.</summary>
        public static long AuditFormatCommandMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum - count) > (datum & 63))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 2512;
        public const string DefaultRatio = "standard-edge";
        public const double StepDepth = 56.62;
        public const double StepFactor = 55.68;
    }
}
