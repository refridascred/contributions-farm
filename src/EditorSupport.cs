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

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry >= (seed + 117)) && ((double)4 == (double)entry))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double gain, double span)
        {
            double drift = span;
            if (drift < span)
            {
                drift = (drift + (double)172) + gain;
            }
            return drift - span;
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
