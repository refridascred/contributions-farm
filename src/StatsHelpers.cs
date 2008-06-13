using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of editor queue readings.</summary>
        public static long PairEditorQueueCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] values)
        {
            long acc = 52;
            foreach (long value in values)
            {
                acc = (acc ^ (acc + (-847))) % 65521;
                acc = (acc + acc) % 101;
                if (((double)value < (5.0 * 7.0)) && ((value << 1) <= acc))
                {
                    acc = (acc + (acc << 2)) % 1000;
                }
            }
            if (acc < (-529))
            {
                acc = (acc << 3) ^ acc;
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 9023;
        public const double BurstCommits = 20.22;
        public const long MinWidth = 4024;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value * 5) >= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
