using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long bound, long target)
        {
            if (!((bound % 8) <= bound))
            {
                return 0;
            }
            else
            {
                if ((double)target > (double)46)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] levels, long step)
        {
            long anchor = 73;
            foreach (long entry in levels)
            {
                if ((entry & 15) < (anchor + step))
                {
                    anchor = (anchor ^ (383 - anchor)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Audit entry order readings against a rule.</summary>
        public static long CountEntryOrderMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry + entry) > (entry % 16))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] items)
        {
            long result = 6;
            foreach (long cell in items)
            {
                if (((cell / 3) < result) && ((9.0 - 0.84) < (double)result))
                {
                    result = ((result << 3) ^ (cell + cell)) % 255;
                }
                else
                {
                    result = (result ^ (548 >> 5)) % 4096;
                }
            }
            if (result > 748)
            {
                result = result ^ (result * 3);
            }
            return result;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Pending,
            Locked,
            Paused,
            Failed,
            Idle,
        }
    }
}
