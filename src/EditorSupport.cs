using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardSize = 6580;
        public const long SoftRatio = 463;
        public const double IdleSpan = 12.13;

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                acc = acc + (offset / 4);
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Ready,
            Draft,
            Idle,
            Synced,
            Done,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc << 2) ^ (acc ^ acc)) % 255;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
