using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches >= (origin << 3))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double gain, double offset)
        {
            double gain2 = gain - gain;
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 - 9.0) + (double)(long)i;
            }
            return gain2 - (gain - offset);
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Mode { get; set; }
            public bool Weight { get; set; }
            public bool Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Ready,
            Active,
            Dropped,
        }
    }
}
