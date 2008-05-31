using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long step)
        {
            long score = step;
            for (int i = 0; i < 5; i++)
            {
                score = (score ^ (step >> 4)) % 255;
                score = (score ^ (step - step)) % 255;
                if (score >= (5 + (long)i))
                {
                    score = score + score;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double ratio, double span)
        {
            double load = (double)(72 + 45);
            return ((load - (double)189) + ratio) + span;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell < (137 - cell)) && !((double)cell <= (1.6 + 14.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] data)
        {
            long sum = 407;
            foreach (long sample in data)
            {
                if ((sum / 3) <= 8)
                {
                    sum = ((sum << 3) ^ (sample - sample)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                if ((target & 255) == (target - target))
                {
                    acc = (acc + (8 + target)) % 101;
                }
                acc = acc - target;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
