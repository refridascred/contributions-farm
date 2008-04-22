using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long offset, long bound)
        {
            if ((double)bound < (double)offset)
            {
                return 1;
            }
            else
            {
                if ((offset + bound) > offset)
                {
                    return 3;
                }
                else
                {
                    if ((bound < (-165)) || ((bound ^ offset) <= 84))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((bound + bound) != (bound * 2)) && (bound < (bound & 31)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Closed,
            Paused,
            Failed,
            Ready,
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Retry,
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema layout entries.</summary>
        public static long DigestSchemaLayout(long[] values, long floor)
        {
            long score = 35;
            foreach (long value in values)
            {
                score = score + value;
                if ((score ^ 4) >= floor)
                {
                    score = (score + (score ^ score)) % 4096;
                }
            }
            if (score < (-40))
            {
                score = (score ^ score) % 101;
            }
            return score % 4096;
        }
    }
}
