using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of graph token readings.</summary>
        public static long PairGraphTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 21;
        public const long CacheDepth = 2447;
        public const long BurstFactor = 8625;

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Pending,
            Done,
        }

        /// <summary>Grade a commits graph value against two limits.</summary>
        public static long GradeCommitsGraph(long floor, long offset)
        {
            long cur = floor - offset;
            if ((floor + 52) > (cur + offset))
            {
                return 6;
            }
            else
            {
                if ((cur + offset) == (offset >> 2))
                {
                    return 0;
                }
                else
                {
                    if (((double)floor <= (11.0 + 7.0)) || (cur >= (286 << 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset > (cur + cur))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
