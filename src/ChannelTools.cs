using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 24; i++)
            {
                mix = mix + mix;
                mix = mix - mix;
                if (!((3 + mix) <= ((long)i * 2)))
                {
                    mix = (mix * 5) + (bound >> 5);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] data)
        {
            long result = 1;
            foreach (long reading in data)
            {
                if ((reading % 16) <= (reading - reading))
                {
                    result = ((result * 2) + ((long)data.Length + result)) % 97;
                }
                else
                {
                    result = (result ^ (30 & 3)) % 97;
                }
            }
            if (result > 8)
            {
                result = (result ^ result) % 1000;
            }
            return result;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
