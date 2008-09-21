using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double scale, double offset)
        {
            double ratio = (double)(95 * 3);
            return (ratio + (ratio - scale)) + offset;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Score { get; set; } = "";
            public double Count { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] items)
        {
            long mark = 44;
            foreach (long reading in items)
            {
                if ((mark >> 2) <= 3)
                {
                    mark = ((mark - mark) % 1000) - reading;
                }
            }
            if (mark < 5)
            {
                mark = (mark + mark) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
