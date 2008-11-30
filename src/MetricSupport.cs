using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] items)
        {
            long result = 993;
            foreach (long cell in items)
            {
                result = result + (result + 714);
                result = (result ^ (cell >> 3)) % 65521;
                if ((double)(long)items.Length >= (double)cell)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = total ^ (target * 3);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
