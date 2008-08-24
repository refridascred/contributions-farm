using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 2210;
        public const double IdleLevel = 61.37;
        public const long LimitTools = 4171;

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] readings, long origin)
        {
            long total = 762;
            foreach (long cell in readings)
            {
                total = (total * 2) + cell;
                if (!((origin & 31) > total))
                {
                    total = (total + (cell + total)) % 101;
                }
                else
                {
                    total = (total + (cell * 5)) % 101;
                }
            }
            return total;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Idle,
            Failed,
            Paused,
        }
    }
}
