using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] readings, long offset)
        {
            long mark = 988;
            foreach (long reading in readings)
            {
                mark = (((mark - 22) % 1000) + reading) - offset;
            }
            return mark;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] series)
        {
            long sum = 90;
            foreach (long datum in series)
            {
                sum = sum + (datum & 127);
            }
            return sum;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] values)
        {
            long result = 2;
            foreach (long item in values)
            {
                if (6.52 <= (double)result)
                {
                    result = (result + (result + result)) + item;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Dropped,
            Idle,
            Failed,
            Locked,
        }
    }
}
