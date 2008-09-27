using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up window layout samples.</summary>
        public static long MatchWindowLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Draft,
            Active,
            Failed,
            Synced,
            Closed,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                score = (score << 3) ^ score;
                score = ((score * 3) + (long)i) % 101;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
