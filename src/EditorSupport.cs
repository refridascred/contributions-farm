using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long bound, long origin)
        {
            long edge = bound + origin;
            if (0.5 < (double)edge)
            {
                return 6;
            }
            else
            {
                if (origin < (bound + 78))
                {
                    return 7;
                }
                else
                {
                    if (((double)edge < (4.97 + 13.0)) || ((origin + bound) <= 86))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum - floor) % 4096;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of tools cluster entries.</summary>
        public static long TallyToolsCluster(long[] readings, long step)
        {
            long carry = 2;
            foreach (long datum in readings)
            {
                carry = (carry - (datum + step)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Locate a githubfarm stream reading by value.</summary>
        public static long LocateGithubfarmStreamIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
