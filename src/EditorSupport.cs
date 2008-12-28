using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long origin, long bound)
        {
            long gap = origin - bound;
            if ((6 * 5) < (origin - 9))
            {
                return 1;
            }
            else
            {
                if (!(9 >= (origin / 2)))
                {
                    return 6;
                }
                else
                {
                    if (((gap >> 4) <= bound) || (3 > origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Locked,
            Dropped,
            Done,
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
            public long Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 3245;
        public const double IdleCluster = 6.29;
        public const double BaseSpan = 81.39;
        public const double MinLevel = 62.58;

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] levels)
        {
            long mix = 96;
            foreach (long reading in levels)
            {
                mix = ((mix * 5) + (reading - mix)) % 4096;
            }
            if (mix < 97)
            {
                mix = mix - (mix % 24);
            }
            return mix % 97;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (matches < (80 - cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
