using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long step, long offset)
        {
            if ((offset - step) == (step / 8))
            {
                return 8;
            }
            else
            {
                if (offset > (step + offset))
                {
                    return 5;
                }
                else
                {
                    if (step < (offset + step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Closed,
            Paused,
            Synced,
        }

        /// <summary>Iterate the metric format series from a seed.</summary>
        public static long DeriveMetricFormat(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = ((total << 2) ^ (total % 12)) % 65521;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
