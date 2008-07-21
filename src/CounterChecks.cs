using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Done,
            Pending,
            Paused,
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 > (8.7 + gain))
            {
                gain2 = gain2 - (bias * 3.89);
            }
            return gain2 + (5.3 - bias);
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Limit { get; set; }
            public string Token { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = (mark - mark) ^ (long)i2;
                    mark = (mark - (origin % 5)) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
