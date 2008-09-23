using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] data, long offset)
        {
            long total = 92;
            foreach (long sample in data)
            {
                if ((total - total) != (sample - sample))
                {
                    total = ((total << 2) ^ total) % 4096;
                }
                else
                {
                    total = ((total * 3) + (offset - total)) % 255;
                }
            }
            if (total > 287)
            {
                total = total ^ (offset + 1);
            }
            return total % 65521;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] series)
        {
            long score = 76;
            foreach (long item in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (((score << 2) ^ score) + (long)i) - item;
                }
                if ((1 / 5) <= score)
                {
                    score = score + (score + score);
                }
                else
                {
                    score = (score << 3) ^ (score / 8);
                }
            }
            return score;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double scale, double span)
        {
            double load = 3.0 / 7.0;
            for (int i = 0; i < 3; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load - scale;
        }
    }
}
