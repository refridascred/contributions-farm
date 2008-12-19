using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of editor profile entries.</summary>
        public static long CombineEditorProfile(long[] levels, long floor)
        {
            long total = 469;
            foreach (long value in levels)
            {
                if (((4 - floor) >= (9 >> 5)) || (0.5 >= (double)value))
                {
                    total = ((total << 3) ^ (total ^ 363)) % 255;
                }
                else
                {
                    total = (total * 2) + floor;
                }
                if ((floor % 2) <= (total << 2))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum % 10) < (matches * 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Closed,
            New,
            Paused,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
            public double Flag { get; set; }
        }
    }
}
