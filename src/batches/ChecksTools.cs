using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Done,
            Closed,
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Region { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] series)
        {
            long anchor = 44;
            foreach (long item in series)
            {
                if ((double)item >= 2.71)
                {
                    anchor = (anchor ^ (item - anchor)) % 255;
                }
            }
            return anchor % 1000;
        }
    }
}
