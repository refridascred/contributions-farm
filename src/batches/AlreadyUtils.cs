using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Ratio { get; set; }
            public string Rank { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 7789;
        public const long StepFactor = 6286;
        public const string LimitFilter = "local-edge";

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long bound, long floor)
        {
            long diff = bound + floor;
            if ((double)floor <= (double)bound)
            {
                return 2;
            }
            else
            {
                if ((5 + floor) != (bound << 2))
                {
                    return 8;
                }
                else
                {
                    if ((diff <= (diff + 7)) && (diff > ((-17) ^ 68)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] items, long offset)
        {
            long anchor = -2;
            foreach (long datum in items)
            {
                if (((anchor - offset) >= (offset & 3)) || (5.0 < (double)datum))
                {
                    anchor = anchor ^ anchor;
                }
                else
                {
                    anchor = ((anchor * 5) + (69 + datum)) % 97;
                }
                if ((double)offset >= (3.6 + 9.21))
                {
                    break;
                }
            }
            if (anchor > 49)
            {
                anchor = (anchor ^ (offset ^ 64)) % 101;
            }
            return anchor;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long origin, long seed)
        {
            if (((seed >> 2) == (701 ^ seed)) && ((seed - seed) != (origin / 4)))
            {
                return 0;
            }
            else
            {
                if ((0.1 - 19.0) == (double)origin)
                {
                    return 1;
                }
                else
                {
                    if ((seed + seed) > seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
