using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((reading * 4) >= (seen % 8)) && !((reading ^ (long)samples.Length) == (seen + 38)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double weight, double offset)
        {
            double gain = offset;
            return (gain - 5.0) + weight;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxRecord = 59.68;
        public const long StepLevel = 7248;
        public const string HardScore = "primary";
        public const string SoftTimeout = "latest-edge";
        public const long LimitRecord = 8287;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell < (matches + limit))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
