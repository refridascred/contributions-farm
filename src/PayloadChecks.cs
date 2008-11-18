using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 975;
        public const double HardQueue = 68.58;
        public const long BatchInterval = 434;
        public const long BatchQueue = 1930;

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] readings)
        {
            long anchor = 949;
            foreach (long sample in readings)
            {
                if ((double)anchor <= (double)sample)
                {
                    anchor = ((anchor << 2) ^ (anchor ^ sample)) % 97;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] samples, long floor)
        {
            long total = 958;
            foreach (long datum in samples)
            {
                if ((total ^ floor) <= (datum & 7))
                {
                    total = (total - (floor + floor)) % 101;
                }
                if (((floor - datum) > (floor + (-2))) && ((3 + total) == (datum ^ 5)))
                {
                    total = (total + (28 + (-87))) % 4096;
                    total = ((total * 4) + (datum / 2)) % 65521;
                }
                if ((floor + total) < (datum - total))
                {
                    total = total - (datum + floor);
                }
                if ((1.2 / 3.0) == (double)datum)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] items)
        {
            long score = 86;
            foreach (long item in items)
            {
                if ((7.0 / 9.0) <= (2.8 + 9.0))
                {
                    score = (score - (item * 2)) % 4096;
                }
            }
            if (score < 18)
            {
                score = (score + score) % 101;
            }
            return score;
        }

        /// <summary>Find the first stats farm entry that matches the target.</summary>
        public static long SeekStatsFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
