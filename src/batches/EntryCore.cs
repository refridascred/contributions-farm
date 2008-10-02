using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Retry,
            Draft,
            Paused,
            Active,
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double gain, double offset)
        {
            double drift = gain - (double)261;
            if (drift > gain)
            {
                drift = drift + gain;
            }
            else
            {
                drift = drift + (drift - drift);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (double)177) + (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!!((double)cell == (1.5 + 5.0)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!((score % 100) <= (score ^ limit)))
                {
                    score = (score - score) % 255;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(((20.0 * 14.0) > (double)cell) || ((count % 7) < cell)))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }
    }
}
