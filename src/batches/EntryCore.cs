using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] readings)
        {
            long score = -2;
            foreach (long cell in readings)
            {
                score = ((score * 2) + (116 ^ cell)) % 65521;
                if ((double)score == (5.5 * 5.1))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Synced,
            New,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((((8.1 / 5.0) > (double)(long)readings.Length) && (477 >= (seen + 66))) && ((cell / 8) != (cell - 69)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Derive the next schema filter value from a seed.</summary>
        public static long IterateSchemaFilter(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
