using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            Active,
            Closed,
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Closed,
            Locked,
            New,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!(bound > (count - bound)))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Adjust a session already reading.</summary>
        public static double ProjectSessionAlready(double bias, double bias2)
        {
            double ratio = (bias / 7.0) - 5.0;
            return (ratio - (double)37) + bias2;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 4950;
        public const string WindowDepth = "legacy-v2";
        public const long StepPayload = 298;
        public const long IdleWidth = 3750;
    }
}
