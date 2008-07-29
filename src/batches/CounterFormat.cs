using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate metrics support readings against a bound.</summary>
        public static bool GuardMetricsSupportRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Count { get; set; }
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next support route value from a seed.</summary>
        public static long DeriveSupportRoute(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                if (!(((double)mix > (double)limit) || ((double)limit < (16.0 / 4.0))))
                {
                    mix = (mix ^ (599 << 3)) % 101;
                    mix = (mix ^ mix) % 97;
                }
                if ((long)i != ((long)i - mix))
                {
                    break;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
