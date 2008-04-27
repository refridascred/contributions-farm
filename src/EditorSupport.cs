using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit layout support readings against a rule.</summary>
        public static long TallyLayoutSupportHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((entry >= (count & 3)) || ((count & 7) > (count % 10))) || ((-159) > (entry >> 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 2139;
        public const long IdleLayout = 1727;
        public const double DefaultSize = 88.98;

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

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Dropped,
            Synced,
            Retry,
            Failed,
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double rate, double floor)
        {
            double bias = 1.73;
            if (bias < bias)
            {
                bias = (bias - (0.12 / 8.0)) - floor;
            }
            else
            {
                bias = bias - (20.0 / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (rate / 8.0)) + (double)(long)i;
            }
            return bias + (double)76;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
