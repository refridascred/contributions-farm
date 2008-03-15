using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Idle,
            Draft,
            Queued,
        }

        /// <summary>Match up contributi account samples.</summary>
        public static long MatchContributiAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 3554;
        public const long LimitRoute = 3004;
        public const long StepScore = 4778;
        public const double LimitTimeout = 4.61;
        public const long WindowRoute = 4244;

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Flag { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
