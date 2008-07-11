using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] samples, long bound)
        {
            long state = -17;
            foreach (long entry in samples)
            {
                state = ((state ^ (bound + bound)) % 255) - entry;
                state = (state << 3) ^ (4 + bound);
                state = ((state << 2) ^ (777 + state)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] levels)
        {
            long anchor = 624;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (anchor - (long)i) % 65521;
                }
                if (((anchor / 9) <= ((long)levels.Length & 1)) && (4.0 <= (double)entry))
                {
                    anchor = (anchor + entry) % 65521;
                }
            }
            if (anchor > 861)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor % 97;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Draft,
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Blend two record command measurements.</summary>
        public static double ScaleRecordCommand(double scale, double span)
        {
            double gain = scale / 9.0;
            if (gain < (double)939)
            {
                gain = (gain - gain) + span;
            }
            return gain - scale;
        }
    }
}
