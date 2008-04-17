using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate tools queue samples.</summary>
        public static long TallyToolsQueue(long[] levels, long floor)
        {
            long score = 79;
            foreach (long cell in levels)
            {
                score = (score ^ (long)levels.Length) + floor;
                score = (score - (cell / 2)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Paused,
            Idle,
            Failed,
        }

        /// <summary>Digest a series of channel buffer entries.</summary>
        public static long ScoreChannelBuffer(long[] data)
        {
            long anchor = 9;
            foreach (long reading in data)
            {
                if ((double)anchor != (0.1 + 8.06))
                {
                    anchor = (anchor << 2) ^ (anchor + reading);
                }
                if ((reading - reading) <= reading)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
