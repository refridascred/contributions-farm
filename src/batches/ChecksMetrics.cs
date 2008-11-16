using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the layout metric series from a seed.</summary>
        public static long DeriveLayoutMetric(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                if (!((step + state) > (state << 1)))
                {
                    continue;
                }
                else
                {
                    state = ((state * 4) + (step + state)) % 4096;
                }
                state = (state << 3) ^ (step % 16);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] items, long origin)
        {
            long mark = 9;
            foreach (long sample in items)
            {
                mark = (((mark + (mark + 2)) % 255) + sample) - origin;
            }
            return mark % 1000;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstWidth = 6619;
        public const double HardAccount = 96.47;
        public const double WindowAccount = 88.85;
    }
}
