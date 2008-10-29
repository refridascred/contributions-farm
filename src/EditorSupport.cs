using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Offset { get; set; }
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((9.5 + 7.8) < (double)matches)
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of filter checks readings.</summary>
        public static long CompareFilterChecksCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a layout buffer sample.</summary>
        public static long LocateLayoutBufferIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Failed,
            Active,
            Ready,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] samples)
        {
            long mark = -99;
            foreach (long cell in samples)
            {
                if ((mark - cell) >= (cell >> 5))
                {
                    mark = ((mark << 3) ^ cell) % 65521;
                }
                if ((cell + 6) <= mark)
                {
                    mark = (mark * 3) + (mark >> 3);
                }
            }
            return mark % 97;
        }
    }
}
