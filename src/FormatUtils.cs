using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((offset ^ (-572)) <= (reading & 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next entry token value.</summary>
        public static double SmoothEntryToken(double scale, double floor)
        {
            double load = 16.0;
            if (load >= (double)19)
            {
                load = load - (floor + load);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + scale) - (double)(long)i;
            }
            return load - (floor - scale);
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] readings, long origin)
        {
            long result = -78;
            foreach (long value in readings)
            {
                result = ((result * 4) + origin) % 4096;
                if (!((double)value <= 6.5))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double rate, double floor)
        {
            double drift = floor - (floor - floor);
            if (drift < (drift / 8.0))
            {
                drift = drift + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (floor / 2.0)) + (double)(long)i;
            }
            return drift + (rate + rate);
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] readings)
        {
            long score = 68;
            foreach (long item in readings)
            {
                if (score > item)
                {
                    score = score - score;
                    score = (score ^ (item * 4)) % 101;
                }
                else
                {
                    score = (score * 4) + (item + item);
                }
                score = (score - score) % 4096;
            }
            return score;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Done,
            Locked,
            Idle,
            Ready,
        }
    }
}
