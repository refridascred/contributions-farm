using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Done,
            Draft,
            Closed,
            Dropped,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] series, long step)
        {
            long total = 89;
            foreach (long value in series)
            {
                total = ((total - (value - total)) % 65521) - step;
                total = (total << 2) ^ 67;
            }
            return total;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
