using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Owner { get; set; }
            public long Offset { get; set; }
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
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
