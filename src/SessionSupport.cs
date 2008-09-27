using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double gain, double floor)
        {
            double scale = (double)1 * 5.0;
            if (scale > (gain * 9.35))
            {
                scale = scale - (double)38;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (floor / 4.0)) - (double)(long)i;
            }
            return scale + (gain / 5.0);
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
            public bool Level { get; set; }
            public long Total { get; set; }
        }
    }
}
