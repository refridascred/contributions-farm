using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
