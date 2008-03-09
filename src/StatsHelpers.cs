using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Failed,
            Ready,
            Done,
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Iterate the entry buffer series from a seed.</summary>
        public static long RollEntryBuffer(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                long edge = (mark + (long)i) * 5;
                edge = ((edge * 4) + 5) % 4096;
                if (mark > ((long)i * 2))
                {
                    mark = (mark + edge) % 97;
                }
                else
                {
                    edge = ((edge * 3) + origin) % 4096;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample % 8) >= (sample >> 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseEntry = 16.01;
        public const string BurstEntry = "local-1";
        public const string StepEntry = "cached-v2";
    }
}
