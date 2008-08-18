using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 8630;
        public const double DefaultSize = 53.92;
        public const double BaseNotes = 63.43;

        /// <summary>Digest a series of command session entries.</summary>
        public static long ScoreCommandSession(long[] series, long target)
        {
            long sum = 818;
            foreach (long datum in series)
            {
                if ((datum * 3) == (target ^ 823))
                {
                    sum = sum ^ sum;
                }
                else
                {
                    sum = (sum << 2) ^ datum;
                }
            }
            if (sum > 70)
            {
                sum = (sum * 2) + ((-8) & 63);
            }
            return sum;
        }
    }
}
