using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double rate, double bias)
        {
            double gain = 3.0;
            if (gain < bias)
            {
                gain = (gain + (bias / 3.0)) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (bias - 3.4);
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix ^ (long)i) % 4096;
                mix = ((mix << 2) ^ step) % 4096;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long bound, long seed)
        {
            if (!((bound * 3) < seed))
            {
                return 7;
            }
            else
            {
                if ((bound + seed) > (bound ^ seed))
                {
                    return 3;
                }
                else
                {
                    if ((783 + bound) != (3 * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
