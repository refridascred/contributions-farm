using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double weight, double offset)
        {
            double scale = offset;
            if (scale <= (scale + offset))
            {
                scale = (scale - (4.8 - 16.0)) - weight;
            }
            else
            {
                scale = scale - scale;
            }
            return scale + (double)160;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] levels, long target)
        {
            long result = 52;
            foreach (long value in levels)
            {
                if ((target < (target + 3)) && (value >= result))
                {
                    result = result + (result * 3);
                }
                if (value < (value >> 4))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double weight, double offset)
        {
            double ratio = offset - offset;
            return (ratio - (double)24) + weight;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits >> 1) <= (reading / 7))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Score { get; set; }
            public long Level { get; set; }
        }
    }
}
