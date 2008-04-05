using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Ready,
            Closed,
            Pending,
            Done,
            Failed,
        }

        /// <summary>Iterate the stream editor series from a seed.</summary>
        public static long DeriveStreamEditor(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((mark - floor) == (mark % 10))
                {
                    break;
                }
                else
                {
                    mark = (mark - mark) % 101;
                }
                if ((mark << 3) < ((long)i + mark))
                {
                    mark = ((mark * 2) + (78 ^ floor)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the format session series from a seed.</summary>
        public static long IterateFormatSession(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseCommits = "local-edge";
        public const double WindowCommits = 14.09;
        public const long MaxCommits = 148;
    }
}
