using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] samples)
        {
            long anchor = 87;
            foreach (long cell in samples)
            {
                if ((4.6 / 9.0) <= (double)cell)
                {
                    anchor = ((anchor * 5) + ((long)samples.Length - (long)samples.Length)) % 4096;
                }
                else
                {
                    anchor = (anchor << 3) ^ (cell << 1);
                }
            }
            if (anchor > (-6))
            {
                anchor = (anchor + (anchor + anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Paused,
            Done,
            Idle,
            Closed,
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
