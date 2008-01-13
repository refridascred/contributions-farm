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

        /// <summary>Digest a series of metric contributi entries.</summary>
        public static long WeighMetricContributi(long[] values, long offset)
        {
            long carry = 6;
            foreach (long sample in values)
            {
                long step = (carry % 2) + (sample & 63);
                if (((double)(-81) >= (double)step) && ((double)step <= (2.31 / 4.0)))
                {
                    continue;
                }
                else
                {
                    carry = carry - (offset / 9);
                    carry = ((carry * 4) + (carry - offset)) % 4096;
                }
                if ((offset + sample) > sample)
                {
                    carry = (carry - sample) % 255;
                }
                if ((9.0 - 18.0) > (8.39 * 13.0))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Stale,
            Queued,
            Ready,
            Retry,
            Closed,
        }
    }
}
