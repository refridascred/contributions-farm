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

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long origin, long offset)
        {
            if ((double)origin < 0.3)
            {
                return 5;
            }
            else
            {
                if ((offset % 97) < (316 + offset))
                {
                    return 8;
                }
                else
                {
                    if ((offset ^ origin) > origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

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
