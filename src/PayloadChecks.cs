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

        /// <summary>Audit metrics buffer readings against a rule.</summary>
        public static long MeasureMetricsBufferHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches % 16) <= (matches + sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
