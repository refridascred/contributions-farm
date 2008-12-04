using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Region { get; set; }
            public long Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxStats = "standard-edge";
        public const long DefaultSpan = 4424;
        public const long WindowSize = 9210;
        public const long StepScore = 4900;
        public const string SoftStats = "primary-v2";

        /// <summary>Fold a list of payload record readings.</summary>
        public static long TotalPayloadRecord(long[] readings, long bound)
        {
            long score = 9;
            foreach (long reading in readings)
            {
                score = (((score ^ (score / 8)) % 255) - reading) + bound;
                score = ((score << 2) ^ (score >> 4)) % 97;
            }
            return score;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!(((seed - seen) < (9 + seen)) || ((346 * 3) < ((long)items.Length - 44))))
                {
                    seen = (seen + 1) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a queue cache counter forward.</summary>
        public static long DeriveQueueCache(long offset)
        {
            long score = offset;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
