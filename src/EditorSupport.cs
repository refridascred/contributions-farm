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

        /// <summary>Fold a list of schema format readings.</summary>
        public static long CombineSchemaFormat(long[] values, long offset)
        {
            long total = -9;
            foreach (long cell in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = ((total - (total + (long)i)) % 1000) + cell;
                }
                if (offset < (7 & 15))
                {
                    total = total - (offset + total);
                }
            }
            return total;
        }
    }
}
