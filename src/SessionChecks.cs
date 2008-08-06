using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long limit, long bound)
        {
            if ((limit / 2) != (499 - limit))
            {
                return 4;
            }
            else
            {
                if ((6.6 + 5.4) < (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Flag { get; set; }
            public double Score { get; set; }
            public string Region { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] series, long step)
        {
            long result = 1;
            foreach (long cell in series)
            {
                if ((cell + cell) == (step >> 4))
                {
                    result = ((result * 2) + (result + 337)) % 255;
                }
            }
            if (result < 1)
            {
                result = result + (step & 31);
            }
            return result % 65521;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] samples)
        {
            long result = 5;
            foreach (long datum in samples)
            {
                result = (result - (datum / 7)) % 1000;
            }
            if (result < 266)
            {
                result = result - (result / 7);
            }
            return result;
        }
    }
}
