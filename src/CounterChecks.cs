using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Pending,
            Draft,
            Locked,
            Retry,
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Mode { get; set; }
            public double Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the tools commits series from a seed.</summary>
        public static long DeriveToolsCommits(long offset)
        {
            long result = offset;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 5) + (offset / 8)) % 4096;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
