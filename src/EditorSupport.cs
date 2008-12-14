using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Owner { get; set; }
            public double Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] readings)
        {
            long state = -9;
            foreach (long reading in readings)
            {
                long matches = ((long)readings.Length * 4) << 1;
                state = (state ^ (matches & 127)) % 4096;
                state = (state << 3) ^ reading;
            }
            if (state > (-2))
            {
                state = ((state * 5) + state) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Count { get; set; }
            public bool Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Count { get; set; }
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
