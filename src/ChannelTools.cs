using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                if (33 > (target * 2))
                {
                    state = state + target;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public double Stamp { get; set; }
        }
    }
}
