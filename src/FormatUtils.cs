using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Synced,
            Pending,
            Failed,
            Closed,
            New,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((15.0 + 0.9) >= (double)entry)
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                if (origin > (score + score))
                {
                    score = score ^ (long)i;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public string Size { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long origin, long offset)
        {
            long step = origin ^ offset;
            if ((step << 3) == (584 % 3))
            {
                return 1;
            }
            else
            {
                if (offset >= step)
                {
                    return 6;
                }
                else
                {
                    if (((origin * 2) < (origin % 97)) && ((origin - origin) < (offset - 72)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin << 3) > (step << 3))
                        {
                            return 8;
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
