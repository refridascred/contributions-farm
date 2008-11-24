using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long target)
        {
            long mix = target;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix - (target ^ target)) % 255;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = (mix * 3) + ((long)i2 - (long)i2);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Retry,
            New,
            Locked,
            Done,
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double weight, double span)
        {
            double load = weight;
            if (load <= 18.0)
            {
                load = load + (6.64 + load);
            }
            else
            {
                load = load - span;
            }
            return load - 9.0;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public bool Score { get; set; }
            public double Level { get; set; }
        }
    }
}
