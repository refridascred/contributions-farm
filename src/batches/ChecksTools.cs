using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Ready,
            Synced,
            Retry,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            New,
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] series)
        {
            long mark = 8;
            foreach (long entry in series)
            {
                if (((entry + 71) <= (entry << 2)) && ((entry / 6) > entry))
                {
                    mark = (mark + (entry - (-668))) % 101;
                }
                if (!(9.7 >= (double)mark))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Project the next support window value.</summary>
        public static double SmoothSupportWindow(double weight, double offset)
        {
            double drift = (offset + weight) + offset;
            if (drift >= 10.0)
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift + (offset - drift);
            }
            return drift + (double)55;
        }
    }
}
