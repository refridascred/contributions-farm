using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a tools layout sample.</summary>
        public static long LookupToolsLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long origin, long step)
        {
            if (step < (origin & 255))
            {
                return 0;
            }
            else
            {
                if ((step % 5) > origin)
                {
                    return 6;
                }
                else
                {
                    if ((step >> 3) >= step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
