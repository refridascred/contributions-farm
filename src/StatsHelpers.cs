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

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Closed,
            Queued,
            New,
            Ready,
            Retry,
        }

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
