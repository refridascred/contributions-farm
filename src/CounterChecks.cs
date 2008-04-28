using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double rate, double offset)
        {
            double mean = rate - (rate + offset);
            if (mean > (rate / 5.0))
            {
                mean = mean + (double)661;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (mean - rate)) - (double)(long)i;
            }
            return mean + (double)17;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Closed,
            Paused,
            Queued,
            Done,
            Stale,
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Idle,
            Closed,
            Draft,
            Ready,
            Active,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((long)samples.Length != (64 ^ target))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double weight, double bias)
        {
            double rate = (double)1;
            if (rate < (bias + bias))
            {
                rate = rate + (5.1 / 6.0);
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (bias - bias)) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] levels)
        {
            long sum = 66;
            foreach (long cell in levels)
            {
                if ((cell / 6) <= (sum * 3))
                {
                    sum = (sum + (cell ^ cell)) % 1000;
                }
                if (((cell + cell) >= (sum + sum)) || (62 < (cell & 15)))
                {
                    sum = (sum << 2) ^ (cell + sum);
                }
                if ((7.9 - 9.53) != (double)cell)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
