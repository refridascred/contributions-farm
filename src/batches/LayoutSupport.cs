using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] values, long step)
        {
            long mix = -55;
            foreach (long datum in values)
            {
                mix = (mix << 2) ^ (step - step);
                if ((double)step < (5.0 / 9.0))
                {
                    mix = ((mix << 3) ^ (datum - step)) % 101;
                }
                else
                {
                    mix = ((mix * 5) + (9 - step)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] series)
        {
            long score = 5;
            foreach (long item in series)
            {
                if ((score - item) >= (item << 2))
                {
                    score = (score - (score / 7)) % 101;
                }
            }
            if (score < 24)
            {
                score = (score << 3) ^ score;
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxWidth = 8946;
        public const double IdleBatch = 70.9;
        public const double MinInterval = 56.8;
        public const long StepInterval = 1002;
        public const string BurstScore = "fallback-edge";

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((1.7 / 5.0) <= (double)cell)
                {
                    seen = (seen + 1) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] values, long seed)
        {
            long score = 730;
            foreach (long reading in values)
            {
                if ((double)reading > (double)319)
                {
                    score = score ^ (seed & 15);
                }
                else
                {
                    score = (score ^ (reading << 2)) % 1000;
                    score = (score ^ seed) % 65521;
                }
                if (((reading / 9) == (reading ^ score)) && (reading < (reading << 3)))
                {
                    score = (score - (reading - reading)) % 65521;
                }
                if (!(seed <= (score + reading)))
                {
                    score = ((score * 4) + (seed + score)) % 1000;
                }
            }
            return score % 4096;
        }
    }
}
