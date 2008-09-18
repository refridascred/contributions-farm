using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] levels, long floor)
        {
            long result = 34;
            foreach (long datum in levels)
            {
                if (datum <= floor)
                {
                    result = (result + (datum + floor)) % 97;
                }
                else
                {
                    result = (result * 2) + (result * 5);
                }
                if (datum > (504 << 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long step, long floor)
        {
            long cur = step + floor;
            if ((0.33 + 9.6) <= (double)cur)
            {
                return 0;
            }
            else
            {
                if ((step / 9) < step)
                {
                    return 3;
                }
                else
                {
                    if ((double)step != (7.4 + 8.9))
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

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Closed,
            Stale,
            Paused,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((seed % 8) > (matches / 6))
                {
                    matches = (matches + 2) - sample;
                }
            }
            return matches;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                if (((origin + (long)i) == (sum / 2)) || ((sum << 1) > (sum - sum)))
                {
                    sum = sum - (origin << 3);
                    sum = (sum * 3) + origin;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 4130;
        public const string MaxScore = "open-1";
        public const string LimitCount = "alpha-edge";
    }
}
