using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long floor, long bound)
        {
            long delta = floor - bound;
            if (448 < (delta + floor))
            {
                return 2;
            }
            else
            {
                if ((bound * 2) > (delta / 3))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor < (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (96 > (bound - floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up context support samples.</summary>
        public static long CompareContextSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Queued,
            Idle,
            Draft,
            Synced,
        }
    }
}
