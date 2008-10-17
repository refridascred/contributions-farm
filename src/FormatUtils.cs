using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)item != (6.43 + 10.0))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
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

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((3.2 + 3.5) > (double)step))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
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
