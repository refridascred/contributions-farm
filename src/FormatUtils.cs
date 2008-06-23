using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Draft,
            New,
            Stale,
            Retry,
            Paused,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long offset, long bound)
        {
            long delta = offset + bound;
            if (((delta << 3) > 721) && ((bound - delta) >= delta))
            {
                return 1;
            }
            else
            {
                if ((delta % 5) != (delta / 3))
                {
                    return 2;
                }
                else
                {
                    if (6.48 > (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = ((state << 3) ^ (target & 15)) % 4096;
                state = state + state;
                if (((state + 2) != (597 + 954)) || ((89 & 127) <= (state - state)))
                {
                    state = ((state << 3) ^ (5 + target)) % 97;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count + count) != (98 % 7))
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
