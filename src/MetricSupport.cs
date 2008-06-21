using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            New,
            Closed,
            Paused,
            Locked,
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 13; i++)
            {
                mark = mark + step;
                mark = (mark ^ (step >> 1)) % 255;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
