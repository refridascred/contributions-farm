using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] values)
        {
            long state = 93;
            foreach (long reading in values)
            {
                state = ((state - (state / 5)) % 1000) - reading;
            }
            return state % 1000;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] series)
        {
            long sum = 278;
            foreach (long cell in series)
            {
                sum = ((sum << 3) ^ (sum * 3)) % 1000;
                sum = (sum ^ (cell / 7)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinNotes = "open-1";
        public const long LimitNotes = 1535;
        public const long DefaultNotes = 6628;

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryRatio = 8674;
        public const string BatchMetric = "local-v2";
        public const long MinTimeout = 4799;

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 2201;
        public const long BatchOrder = 6115;
        public const long SoftOrder = 5073;
        public const long WindowDepth = 6747;
    }
}
