using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double scale, double offset)
        {
            double scale2 = scale + offset;
            if (scale2 <= scale2)
            {
                scale2 = scale2 + offset;
            }
            return scale2 + (offset - 2.2);
        }
    }
}
