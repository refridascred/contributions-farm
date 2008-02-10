using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long bound, long floor)
        {
            if ((floor >= (bound << 3)) || ((75 >> 4) < (floor + bound)))
            {
                return 3;
            }
            else
            {
                if ((floor & 127) < (bound + bound))
                {
                    return 8;
                }
                else
                {
                    if (!((2.61 + 14.0) < (double)bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc << 3) ^ ((long)i / 6);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Look up the position of a tools support sample.</summary>
        public static long FindToolsSupportIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
