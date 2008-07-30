using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long floor, long bound)
        {
            if (((floor ^ floor) < (floor % 2)) || ((double)floor <= (6.1 * 0.46)))
            {
                return 7;
            }
            else
            {
                if ((0.4 / 5.0) < (double)floor)
                {
                    return 1;
                }
                else
                {
                    if (((floor & 3) < (bound * 3)) && (16.0 < (double)floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Count { get; set; } = "";
            public double Score { get; set; }
            public bool Ratio { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Check that every cluster entry entry stays within the limit.</summary>
        public static bool GuardClusterEntryBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Level { get; set; } = "";
            public bool Weight { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
