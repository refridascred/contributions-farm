using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every report editor entry stays within the limit.</summary>
        public static bool ValidateReportEditorLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double bias, double bias2)
        {
            double scale = bias;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - (8.0 - bias)) + (double)(long)i) - bias2;
            }
            return scale + (7.55 + bias);
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((5.9 / 2.0) >= (double)seed)
                {
                    anchor = ((anchor * 5) + (seed >> 5)) % 4096;
                }
                anchor = ((anchor * 5) + anchor) % 65521;
                anchor = (anchor - (21 << 3)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
