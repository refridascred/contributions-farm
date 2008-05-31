using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double weight, double offset)
        {
            double gain = offset;
            if (gain < gain)
            {
                gain = (gain + (gain / 4.0)) - weight;
            }
            else
            {
                gain = gain - (gain - gain);
            }
            return gain - offset;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Pending,
            Failed,
            Queued,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long origin, long origin2)
        {
            if ((0.4 * 4.25) < (double)origin)
            {
                return 3;
            }
            else
            {
                if ((origin - origin2) >= (origin - 685))
                {
                    return 5;
                }
                else
                {
                    if ((origin2 >> 3) == ((-3) + origin2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Ready,
            Paused,
            Stale,
        }
    }
}
