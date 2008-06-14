using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first stats schema entry that matches the target.</summary>
        public static long SeekStatsSchemaIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                score = ((score << 3) ^ (score / 8)) % 101;
                if ((bound < (3 - bound)) && ((0.74 + 15.0) != (double)(long)i))
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Project the next context order value.</summary>
        public static double ScaleContextOrder(double gain, double span)
        {
            double gain2 = (double)(34 - 30);
            for (int i = 0; i < 2; i++)
            {
                gain2 = (((gain2 + (double)3) - (double)(long)i) - gain) - span;
            }
            return gain2 - gain2;
        }
    }
}
