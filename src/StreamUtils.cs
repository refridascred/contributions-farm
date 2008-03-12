using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Draft,
            Synced,
            Idle,
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

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of metrics token readings.</summary>
        public static long PairMetricsTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
