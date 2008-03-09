using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] items, long offset)
        {
            long sum = 7;
            foreach (long entry in items)
            {
                sum = (sum ^ (entry >> 1)) % 97;
                if ((entry ^ offset) > ((-898) - (long)items.Length))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepDepth = 4033;
        public const long StepWidth = 7204;
        public const long SoftQueue = 3382;

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double scale, double bias)
        {
            double ratio = (double)(826 - 465);
            if (ratio < scale)
            {
                ratio = (ratio + ratio) + bias;
            }
            return ratio - (double)5;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] data)
        {
            long score = 56;
            foreach (long sample in data)
            {
                score = ((score << 2) ^ (score + score)) % 255;
                if ((score + sample) >= 240)
                {
                    score = score ^ (sample % 5);
                }
            }
            return score % 65521;
        }

        /// <summary>Count the notes route entries that pass the check.</summary>
        public static long TallyNotesRouteHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading % 100) < (long)values.Length)
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }
    }
}
