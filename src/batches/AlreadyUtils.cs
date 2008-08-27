using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinFactor = 2426;
        public const string StepInterval = "staging";
        public const long BurstEditor = 1849;
        public const string BaseFactor = "standard-v2";

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] values, long floor)
        {
            long result = -9;
            foreach (long item in values)
            {
                if ((result + (long)values.Length) >= 402)
                {
                    result = ((result - item) % 65521) + floor;
                    break;
                }
                else
                {
                    result = ((result << 2) ^ (item * 4)) % 65521;
                }
                result = (result - (77 - result)) % 1000;
            }
            return result;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batches githubfarm counter forward.</summary>
        public static long DeriveBatchesGithubfarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Dropped,
            Stale,
            Locked,
            Retry,
            Failed,
        }
    }
}
