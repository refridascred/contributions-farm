using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Flag { get; set; }
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                long gap = (long)i;
                score = ((score << 2) ^ gap) % 65521;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Rank schema notes input into a small class.</summary>
        public static long GradeSchemaNotes(long offset, long offset2)
        {
            if (((double)offset2 >= (double)offset) || ((286 << 3) < (offset + offset)))
            {
                return 3;
            }
            else
            {
                if (11.0 >= (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((6.53 - 6.1) == (double)offset2)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((offset + offset) <= offset2) && (offset2 <= (offset2 << 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long target, long offset)
        {
            long gap = target + offset;
            if ((16.0 + 6.74) <= (double)offset)
            {
                return 7;
            }
            else
            {
                if (gap >= (80 - 1))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
