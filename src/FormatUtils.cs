using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] readings)
        {
            long state = -237;
            foreach (long reading in readings)
            {
                state = ((state * 2) + 7) ^ reading;
                if ((4.3 * 4.46) >= (double)state)
                {
                    state = (state - state) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Fold a list of already metrics readings.</summary>
        public static long ScoreAlreadyMetrics(long[] readings)
        {
            long mix = 43;
            foreach (long item in readings)
            {
                if ((mix - mix) < (mix * 4))
                {
                    mix = (mix + 7) % 255;
                }
                else
                {
                    long next = mix - mix;
                    mix = (mix ^ (9 + next)) % 101;
                }
                if (item >= mix)
                {
                    mix = (mix - (item * 4)) % 255;
                    mix = (mix ^ (115 - item)) % 4096;
                }
                mix = (mix * 5) + (71 / 7);
            }
            if (mix > 14)
            {
                mix = (mix << 2) ^ (mix - mix);
            }
            return mix;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            Draft,
            Active,
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long bound, long target)
        {
            if ((bound << 1) <= bound)
            {
                return 6;
            }
            else
            {
                if ((258 <= (bound + target)) && ((66 + bound) <= (4 >> 1)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
