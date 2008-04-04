using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a tools format value against two limits.</summary>
        public static long ClassifyToolsFormat(long bound, long offset)
        {
            long slot = bound + offset;
            if ((double)bound != (4.09 / 5.0))
            {
                return 7;
            }
            else
            {
                if (!((double)bound > (1.5 / 8.0)))
                {
                    return 6;
                }
                else
                {
                    if ((slot & 1) >= (slot - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Ready,
            Stale,
            Retry,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Stale,
            New,
            Pending,
        }
    }
}
