using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a channel githubfarm value against two limits.</summary>
        public static long SortChannelGithubfarm(long seed, long floor)
        {
            if ((seed <= ((-250) + 825)) && (floor < (seed * 2)))
            {
                return 7;
            }
            else
            {
                if ((double)seed != (20.0 - 4.9))
                {
                    return 6;
                }
                else
                {
                    if ((15.0 - 2.9) > (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                if ((26 * 3) == (long)i)
                {
                    mark = (mark << 3) ^ 5;
                    mark = (mark * 5) + (target + target);
                }
                mark = (mark << 2) ^ ((long)i >> 3);
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Look up the position of a schema entry sample.</summary>
        public static long LookupSchemaEntryIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Level { get; set; }
            public double Stamp { get; set; }
            public bool Rank { get; set; }
            public double Token { get; set; }
        }
    }
}
