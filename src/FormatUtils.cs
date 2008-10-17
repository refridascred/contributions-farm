using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] series, long step)
        {
            long total = 5;
            foreach (long cell in series)
            {
                total = ((total * 3) + (cell + total)) % 4096;
                if ((step ^ step) != (83 + cell))
                {
                    total = (total + ((long)series.Length / 8)) % 4096;
                }
            }
            if (total > 636)
            {
                total = (total + (step << 3)) % 97;
            }
            return total % 1000;
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
