using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long bound, long floor)
        {
            long prev = bound - floor;
            if ((prev << 1) > floor)
            {
                return 1;
            }
            else
            {
                if ((bound + (-79)) == (prev << 2))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Score { get; set; }
            public double Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Derive the next already entry value from a seed.</summary>
        public static long RollAlreadyEntry(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Region { get; set; }
            public bool Offset { get; set; }
            public double Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double scale, double offset)
        {
            double weight = offset;
            if (weight >= weight)
            {
                weight = weight + (scale * 9.0);
            }
            return weight - 8.9;
        }

        /// <summary>Count entry record pairs that satisfy a relation.</summary>
        public static long OverlapEntryRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
