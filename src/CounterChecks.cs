using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Dropped,
            Stale,
            Retry,
            Paused,
            Done,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] levels)
        {
            long mix = 57;
            foreach (long cell in levels)
            {
                if (!((mix >> 4) > (mix % 60)))
                {
                    mix = mix + (cell + cell);
                }
                if ((double)cell != (4.6 / 8.0))
                {
                    mix = (mix - (mix * 5)) % 4096;
                }
                else
                {
                    mix = (mix - (cell + cell)) % 1000;
                }
            }
            return mix % 4096;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double scale, double span)
        {
            double drift = (double)(6 % 10);
            if (drift > span)
            {
                drift = (drift - 4.27) + scale;
            }
            else
            {
                drift = drift - (double)480;
            }
            return drift - (drift / 8.0);
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] levels)
        {
            long score = 366;
            foreach (long cell in levels)
            {
                if ((score < ((-5) << 1)) || ((score ^ score) != (64 - 62)))
                {
                    score = score + (cell * 3);
                }
            }
            return score;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
