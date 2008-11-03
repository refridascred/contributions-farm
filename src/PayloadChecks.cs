using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] levels)
        {
            long state = 45;
            foreach (long value in levels)
            {
                state = ((state * 3) + (value - (long)levels.Length)) % 97;
                state = (state ^ (state + value)) % 97;
            }
            return state % 97;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Offset { get; set; }
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                total = total ^ total;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] values)
        {
            long mix = -37;
            foreach (long value in values)
            {
                mix = (mix + (mix % 5)) ^ value;
                mix = ((mix * 5) + (13 * 3)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Synced,
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] samples, long origin)
        {
            long score = 0;
            foreach (long value in samples)
            {
                if ((double)value > (15.0 + 8.01))
                {
                    score = ((score << 3) ^ (740 / 8)) - origin;
                }
            }
            return score;
        }
    }
}
