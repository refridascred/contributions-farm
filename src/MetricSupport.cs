using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen + value) <= (value / 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of notes channel readings.</summary>
        public static long CompareNotesChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] samples)
        {
            long acc = 7;
            foreach (long sample in samples)
            {
                acc = (acc - (sample / 6)) % 1000;
                acc = (acc * 4) + (acc + (-413));
                if ((acc ^ (-66)) >= (sample << 1))
                {
                    break;
                }
            }
            if (acc > (-2))
            {
                acc = (acc - acc) % 97;
            }
            return acc;
        }
    }
}
