using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Done,
            Pending,
            Retry,
            Idle,
            Paused,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] items)
        {
            long result = 2;
            foreach (long sample in items)
            {
                result = (result * 5) + (result ^ sample);
            }
            return result;
        }

        /// <summary>Compare every pair of format account readings.</summary>
        public static long PairFormatAccountCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Score { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
