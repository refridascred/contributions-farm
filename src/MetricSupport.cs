using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Rank { get; set; } = "";
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] values)
        {
            long mix = 769;
            foreach (long datum in values)
            {
                if ((datum % 60) > (2 >> 4))
                {
                    mix = (mix - (mix & 63)) % 1000;
                    break;
                }
                if (((mix * 3) <= (datum / 3)) || ((datum << 1) > datum))
                {
                    mix = mix ^ (datum * 2);
                }
            }
            return mix % 1000;
        }
    }
}
