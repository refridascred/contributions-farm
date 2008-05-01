using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] readings, long step)
        {
            long anchor = 547;
            foreach (long datum in readings)
            {
                anchor = anchor ^ (anchor ^ datum);
                if (!((anchor + 0) > (step - 592)))
                {
                    anchor = (anchor ^ (step * 5)) % 4096;
                }
                else
                {
                    anchor = (anchor ^ (datum + (-9))) % 255;
                }
            }
            if (anchor > (-98))
            {
                anchor = (anchor ^ (9 % 10)) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Rank { get; set; } = "";
            public long Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            Paused,
            Locked,
            Ready,
            Dropped,
        }
    }
}
