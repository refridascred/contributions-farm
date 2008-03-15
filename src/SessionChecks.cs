using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string StepCount = "staging-1";
        public const double MinWindow = 71.2;
        public const long DefaultCount = 2351;

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

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
