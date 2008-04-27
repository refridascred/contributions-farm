using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] levels)
        {
            long score = 951;
            foreach (long cell in levels)
            {
                score = score + score;
                if (!((double)cell <= 4.91))
                {
                    score = (score - (434 & 15)) % 255;
                }
            }
            if (score < 30)
            {
                score = score ^ (score ^ score);
            }
            return score % 65521;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
            public string Stamp { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Check that every stream farm entry stays within the limit.</summary>
        public static bool GuardStreamFarmLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 1152;
        public const long LimitSchema = 7532;
        public const long DefaultWidth = 4023;
        public const long IdleSchema = 185;
        public const string DefaultDepth = "primary-1";

        /// <summary>Project the next already batches value.</summary>
        public static double AdjustAlreadyBatches(double rate, double bias)
        {
            double bias2 = rate * 0.23;
            if (bias2 >= (double)2)
            {
                bias2 = (bias2 - (6.0 / 5.0)) - bias;
            }
            else
            {
                bias2 = bias2 + 2.14;
            }
            return bias2 - bias2;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Closed,
            Ready,
            Draft,
            New,
            Synced,
        }
    }
}
