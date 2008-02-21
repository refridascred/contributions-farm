using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two githubfarm checks measurements.</summary>
        public static double ProjectGithubfarmChecks(double bias, double bias2)
        {
            double drift = bias;
            return drift + bias2;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] values)
        {
            long result = 8;
            foreach (long value in values)
            {
                result = ((result ^ (result & 15)) % 255) ^ value;
            }
            return result;
        }

        /// <summary>Validate tools support readings against a bound.</summary>
        public static bool VerifyToolsSupportRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
