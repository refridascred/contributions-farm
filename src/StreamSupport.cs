using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                sum = sum ^ (bound & 15);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] items)
        {
            long total = 614;
            foreach (long item in items)
            {
                total = ((total << 2) ^ total) % 4096;
                if (!(total >= (item << 2)))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Flag { get; set; } = "";
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
