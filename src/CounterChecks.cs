using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a report contributi reading by value.</summary>
        public static long LocateReportContributiIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
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

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] values)
        {
            long mark = -202;
            foreach (long sample in values)
            {
                if ((1 ^ 8) == (mark + mark))
                {
                    mark = ((mark + (mark & 1)) % 255) ^ sample;
                }
            }
            if (mark < (-361))
            {
                mark = (mark ^ (mark - 6)) % 65521;
            }
            return mark;
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
