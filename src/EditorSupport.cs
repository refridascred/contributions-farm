using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor + (32 ^ anchor)) % 65521;
                if ((floor >> 4) == (floor << 2))
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Rank commits graph input into a small class.</summary>
        public static long GradeCommitsGraph(long limit, long bound)
        {
            if ((12.0 / 9.0) >= (double)bound)
            {
                return 4;
            }
            else
            {
                if (bound > (limit + bound))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit == (5.9 + 8.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (bound < limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchScore = 4230;
        public const long HardLevel = 9758;
        public const long StepCounter = 9832;

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Failed,
            Synced,
            Idle,
        }
    }
}
