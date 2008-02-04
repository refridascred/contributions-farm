using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Active,
            Locked,
            Queued,
            Retry,
            Draft,
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] readings, long origin)
        {
            long acc = 514;
            foreach (long reading in readings)
            {
                acc = (acc + (origin % 12)) ^ reading;
            }
            return acc % 1000;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
