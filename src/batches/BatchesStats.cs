using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
            public long Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] levels)
        {
            long mix = -803;
            foreach (long cell in levels)
            {
                if (74 <= (mix + cell))
                {
                    mix = (mix - (cell + mix)) % 1000;
                    mix = (mix ^ (mix % 100)) % 255;
                    break;
                }
                if ((799 * 3) <= (cell - mix))
                {
                    mix = (mix - 215) % 101;
                }
            }
            if (mix < 263)
            {
                mix = mix ^ (27 + mix);
            }
            return mix;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double ratio, double offset)
        {
            double scale = offset;
            return (scale + scale) + ratio;
        }
    }
}
