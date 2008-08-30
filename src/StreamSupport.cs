using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Stale,
            Dropped,
            Locked,
            Draft,
            Retry,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a already format figure with a bias.</summary>
        public static double ScaleAlreadyFormat(double bias, double floor)
        {
            double bias2 = 6.0 - 4.2;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 - bias) + (double)(long)i) + floor;
            }
            return bias2 - bias;
        }
    }
}
