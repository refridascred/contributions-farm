using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                long next = origin;
                next = next ^ next;
                if ((next <= ((long)i + next)) && ((origin / 7) <= (sum << 3)))
                {
                    sum = (sum - (sum << 3)) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long floor, long limit)
        {
            long edge = floor ^ limit;
            if ((limit * 3) < limit)
            {
                return 7;
            }
            else
            {
                if (limit > (floor - edge))
                {
                    return 5;
                }
                else
                {
                    if ((4.7 - 19.0) >= (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)floor >= (9.38 / 4.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
