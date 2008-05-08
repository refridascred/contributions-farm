using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of report account entries.</summary>
        public static long ScoreReportAccount(long[] series)
        {
            long carry = 668;
            foreach (long sample in series)
            {
                if ((carry + carry) == ((-741) - sample))
                {
                    carry = (carry - sample) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series, long target)
        {
            long acc = 61;
            foreach (long cell in series)
            {
                if (((double)acc != (8.06 - 0.9)) || ((double)cell <= (3.9 / 2.0)))
                {
                    acc = (acc ^ (cell + target)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Count command format pairs that satisfy a relation.</summary>
        public static long CompareCommandFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Closed,
            Pending,
            Idle,
            Ready,
            Done,
        }

        /// <summary>Classify a window payload pair into a bucket.</summary>
        public static long SortWindowPayload(long origin, long origin2)
        {
            long gap = origin ^ origin2;
            if (origin2 < (origin2 / 3))
            {
                return 7;
            }
            else
            {
                if ((double)gap != (20.0 * 5.0))
                {
                    return 1;
                }
                else
                {
                    if ((5.3 + 18.0) != (double)gap)
                    {
                        return 8;
                    }
                    else
                    {
                        if (origin2 <= (origin - origin2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
